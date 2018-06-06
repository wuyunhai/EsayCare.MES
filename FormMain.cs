using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Net.NetworkInformation;
using CCWin;
using DM_API;
using SuperSocket.SocketEngine;
using SuperSocket.SocketBase;
using System.Net;
using System.Collections.Concurrent;
using YSJ_IAAPI;
using CCWin.SkinControl;
using System.ComponentModel;

namespace EsayCare.MES
{
    public delegate void WorkStateDelegate(bool IsWork);
    public partial class FormMain : Skin_Metro
    {
        #region var
        #region main

        //标识网络是否通畅
        public bool IsConnectionOK = false;
        //可执行文件路径
        public string ExePath
        {
            get { return AppDomain.CurrentDomain.BaseDirectory; }
        }
        //计时数
        private long timeCounter = 0;
        //日志记录助手
        private LogHelper log;
        //配置文件助手
        private ConfigHelper cfgHelper;

        #endregion

        #region CH_var

        private int interval = 300;
        public delegate void CbDelegate();
        public delegate void CbDelegate<T1>(T1 obj1);
        public delegate void CbDelegate<T1, T2>(T1 obj1, T2 obj2);
        public static event WorkStateDelegate WorkStateChange;
        private bool WorkState;
        private MesServer mesServer;
        private MesSession currentMesSession;
        private YSJMESInterface ySJMESInterface;
        private DM_SFCInterface SFCInterface;
        private List<string> lstWorkOrder;
        private Dictionary<string, string> dicAnimals;
        public static ConcurrentDictionary<string, MesSession> mOnLineConnections = new ConcurrentDictionary<string, MesSession>();

        public string WorkOrder;
        public string SerialNumber;

        /// <summary>
        /// 图片路径
        /// </summary>
        public string SelfPath
        {
            get
            {
                string Path = Assembly.GetExecutingAssembly().Location;
                Path = Path.Substring(0, Path.LastIndexOf('\\'));
                return Path + "\\animals\\";
            }
        }

        #endregion

        #endregion

        #region 构造函数

        public FormMain()
        {
            InitializeComponent();

            #region main

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 在缓冲区重绘
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            #endregion
        }

        #endregion

        #region 窗体载入

        private void FormMain_Load(object sender, EventArgs e)
        {
            #region main 

            GlobalData.InitGlobalData();//初始化全局数据 
            Text = string.Format("IA-MES CS端系统 ({0} - {1})", GlobalData.Process, GlobalData.MachineId);
            CenterImage.Image = Image.FromFile(ExePath + @"Res\Network2.png");
            staStripVersion.Text = "版本：" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            cfgHelper = GlobalData.CfgHelper;
            log = GlobalData.Log;
            log.OnDisplayLog += OnDisplayLog;

            #endregion

            #region CH

            dgvList.AutoGenerateColumns = false;
            SFCInterface = new DM_SFCInterface();
            ySJMESInterface = new YSJMESInterface();
            WorkStateChange += FormMain_WorkStateChange;

            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += AsyncLoadUIPluguns;
            bgw.RunWorkerCompleted += AsyncLoadUIPlugunsCompleted;
            bgw.RunWorkerAsync();//开启异步加载插件模块 

            //启动网络连接监测线程
            Thread threadPing = new Thread(CheckNetConnection);
            threadPing.IsBackground = true;
            threadPing.Priority = ThreadPriority.Lowest;
            threadPing.Start(GlobalData.MESServerIP);
            #endregion
        }

        private void AsyncLoadUIPlugunsCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmbWO.ValueMember = "WorkOrder";
            cmbWO.DataSource = lstWorkOrder;
            cmbWO.SelectedIndex = -1;
        }

        private void AsyncLoadUIPluguns(object sender, DoWorkEventArgs e)
        {
            ShowMessage(ColorHelper.MsgGray, "正在检查MES服务器网络连接...");
            Thread.Sleep(interval);
            if (CheckNetConnection(GlobalData.MESServerIP))
            {
                ShowMessage(ColorHelper.MsgGray, "正在检查EQC服务器网络连接...");
                Thread.Sleep(interval);
                if (CheckNetConnection(GlobalData.EQCServerIP))
                {
                    ShowMessage(ColorHelper.MsgGray, "正在加载属性图片...");
                    Thread.Sleep(interval);
                    LoadAnimal();
                    ShowMessage(ColorHelper.MsgGray, "正在加载制令单数据...");
                    Thread.Sleep(interval);
                    GetWOCollection("CH");
                    ShowMessage(ColorHelper.MsgGray, "正在加载通讯服务...");
                    Thread.Sleep(interval);
                    InitAppServer();
                }
                else
                {
                    ShowMessage(ColorHelper.MsgRed, "EQC服务器网络连接异常...");
                    return;
                }
            }
            else
            {
                ShowMessage(ColorHelper.MsgRed, "MES服务器网络连接异常...");
                return;
            }
        }

        #region 网络检查
        private bool CheckNetConnection(string ip)
        {
            object lockObj = new object();
            Ping ping = new Ping();

            try
            {
                PingReply pingReply = ping.Send(ip, interval);
                if (pingReply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        private void FormMain_WorkStateChange(bool isWork)
        {
            SetWorkStateChange(isWork);
        }

        private void SetWorkStateChange(bool isWork)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<bool>(this.SetWorkStateChange), isWork);
            }
            else
            {
                if (isWork)
                    HandleWork();
                else
                    HandleStop();
            }
        }

        #endregion

        #region 初始化APPServer

        /// <summary>
        /// 启动AppServer
        /// </summary>
        private void InitAppServer()
        {
            try
            {
                //方法一、采用当前应用程序中的【App.config】文件。
                //var bootstrap = BootstrapFactory.CreateBootstrap();

                //=>方法二、采用自定义独立【SuperSocket.config】配置文件
                var bootstrap = BootstrapFactory.CreateBootstrapFromConfigFile("SuperSocket.config");

                #region [=>自定义服务配置]
                //IServerConfig serverConfig = new ServerConfig
                //{
                //    Name = "MesServer",// "AgileServer",//服务器实例的名称
                //    ServerType = "EsayCare.MES.MesServer, EsayCare.MES",
                //    Ip = "Any",//Any - 所有的IPv4地址 IPv6Any - 所有的IPv6地址
                //    Mode = SocketMode.Tcp,//服务器运行的模式, Tcp (默认) 或者 Udp
                //    Port = int.Parse("6543"),//服务器监听的端口
                //    SendingQueueSize = 5000,//发送队列最大长度, 默认值为5
                //    MaxConnectionNumber = 5000,//可允许连接的最大连接数
                //    LogCommand = false,//是否记录命令执行的记录
                //    LogBasicSessionActivity = false,//是否记录session的基本活动，如连接和断开
                //    LogAllSocketException = false,//是否记录所有Socket异常和错误
                //    //Security = "tls",//Empty, Tls, Ssl3. Socket服务器所采用的传输层加密协议
                //    MaxRequestLength = 5000,//最大允许的请求长度，默认值为1024
                //    TextEncoding = "UTF-8",//文本的默认编码，默认值是 ASCII，（###改成UTF-8,否则的话中文会出现乱码）
                //    KeepAliveTime = 60,//网络连接正常情况下的keep alive数据的发送间隔, 默认值为 600, 单位为秒
                //    KeepAliveInterval = 60,//Keep alive失败之后, keep alive探测包的发送间隔，默认值为 60, 单位为秒
                //    ClearIdleSession = true, // 是否定时清空空闲会话，默认值是 false;（###如果开启定时60秒钟情况闲置的连接，为了保证客户端正常不掉线连接到服务器，故我们需要设置10秒的心跳数据包检查。也就是说清除闲置的时间必须大于心跳数据包的间隔时间，否则就会出现服务端主动踢掉闲置的TCP客户端连接。）
                //    ClearIdleSessionInterval = 60,//: 清空空闲会话的时间间隔, 默认值是120, 单位为秒;
                //    SyncSend = true,//:是否启用同步发送模式, 默认值: false;
                //};
                //var rootConfig = new RootConfig()
                //{
                //    MaxWorkingThreads = 5000,//线程池最大工作线程数量
                //    MinWorkingThreads = 10,// 线程池最小工作线程数量;
                //    MaxCompletionPortThreads = 5000,//线程池最大完成端口线程数量;
                //    MinCompletionPortThreads = 10,// 线程池最小完成端口线程数量;
                //    DisablePerformanceDataCollector = true,// 是否禁用性能数据采集;
                //    PerformanceDataCollectInterval = 60,// 性能数据采集频率 (单位为秒, 默认值: 60);
                //    LogFactory = "ConsoleLogFactory",//默认logFactory的名字
                //    Isolation = IsolationMode.AppDomain// 服务器实例隔离级别                
                //};
                #endregion

                if (!bootstrap.Initialize())
                {
                    ShowMessage(ColorHelper.MsgRed, "Failed to initialize!");
                    return;
                }
                StartResult startResult = bootstrap.Start();
                if (startResult == StartResult.Success)
                {
                    this.ShowMessage(ColorHelper.MsgGreen, "服务启动成功，等待设备连接 =>");
                    mesServer = bootstrap.AppServers.Cast<MesServer>().FirstOrDefault();
                    if (mesServer != null)
                    {
                        mesServer.NewSessionConnected += MesServer_NewSessionConnected;
                        mesServer.NewRequestReceived += new RequestHandler<MesSession, MesRequestInfo>(MesServer_NewRequestReceived);
                        mesServer.SessionClosed += MesServer_SessionClosed;

                    }
                    else
                        this.ShowMessage(ColorHelper.MsgRed, "请检查配置文件中是否有可用的服务信息！");
                }
                else
                    this.ShowMessage(ColorHelper.MsgRed, "服务启动失败！");
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        #endregion

        #region 消息接收

        private void MesServer_NewRequestReceived(MesSession session, MesRequestInfo requestInfo)
        {
            if (requestInfo.TData != null)
            {
                switch (requestInfo.Header)
                {
                    case "ISR":
                        if (requestInfo.TData.CheckResult == CheckResultCode.OK.ToString())
                        {
                            WorkState = true;
                            ShowMessage(ColorHelper.MsgGray, "请开始扫描彩盒ID条码.");
                        }
                        else
                        {
                            WorkState = false;
                            ShowMessage(ColorHelper.MsgOrange, "设备未具备开工条件.");
                        }
                        if (WorkStateChange != null)
                            WorkStateChange.Invoke(WorkState);

                        break;
                    case "SNC":
                        ShowSNCheckResult(requestInfo.TData.CheckResult);
                        if (requestInfo.TData.CheckResult == CheckResultCode.OK.ToString())
                        {
                            try
                            {
                                DataTable dt = SFCInterface.SFC_DM_CheckRoute(requestInfo.TData.SN, GlobalData.EquipmentNO, WorkOrder, "PASS");//FAIL 
                                string CheckStatus = dt.Rows[0][0].ToString().ToString();
                                string ReturnMsg = dt.Rows[0][1].ToString().ToString();
                                if (CheckStatus == "1") //成功  
                                {
                                    ShowMessage(ColorHelper.MsgGreen, "MES过站成功>>" + CheckStatus + ":" + ReturnMsg);
                                    // 加载下一条
                                    GetNextSN(WorkOrder);
                                }
                                else
                                {
                                    ShowMessage(ColorHelper.MsgRed, "MES过站失败>>" + CheckStatus + ":" + ReturnMsg);
                                    GetNextSN(WorkOrder);
                                }
                            }
                            catch (Exception ex)
                            {
                                ShowMessage(ColorHelper.MsgRed, "执行过站方法出错>>" + ex.Message);
                            }
                        }
                        else
                        {
                            for (int i = 3; i > 0; i--)
                            {
                                ShowMessage(ColorHelper.MsgRed, "彩盒SN校验失败，【" + i.ToString() + "】秒后重新下发.");
                                Thread.Sleep(1000);
                            }
                            ShowMessage(ColorHelper.MsgOrange, "条码已重新下发.");
                            SendFactory(FunCode.SND.ToString());
                        }
                        break;

                    default:
                        ShowMessage(ColorHelper.MsgRed, "未能识别该功能码：" + requestInfo.Header);
                        break;
                }
            }
            else
            {
                ShowMessage(ColorHelper.MsgRed, "提示：协议格式错误，协议格式：3位功能码 + 空格 + json字符串 + 回车换行符.");
            }
        }

        #endregion

        #region 连接关闭事件

        private void MesServer_SessionClosed(MesSession session, global::SuperSocket.SocketBase.CloseReason value)
        {
            ShowMessage(session.RemoteEndPoint, "断开连接");
            MesSession outMesSession;
            mOnLineConnections.TryRemove(session.SessionID, out outMesSession);
            ShowConnectionCount(mOnLineConnections.Count);
            ShowClientsMessage("close", session);
            currentMesSession = null;
        }

        #endregion

        #region =>[新连接事件]

        void MesServer_NewSessionConnected(MesSession session)
        {
            //if (session.RemoteEndPoint.ToString() == GlobalData.EQCServerIP + ":" + GlobalData.EQCServerPort)
            //{
            ShowMessage(session.RemoteEndPoint, "连接成功！");
            mOnLineConnections.TryAdd(session.SessionID, session);
            ShowConnectionCount(mOnLineConnections.Count);
            ShowClientsMessage("new", session);
            currentMesSession = session;
            //}
            //else
            //{
            //    ShowMessage(session.RemoteEndPoint, "非法设备，已断开其连接！");
            //    session.Close();
            //}
        }

        #endregion

        #region 查询彩盒制令单

        /// <summary>
        /// 查询彩盒制令单
        /// </summary>
        /// <param name="v"></param>
        private void GetWOCollection(string v)
        {
            DataTable dt = new DataTable();
            dt = ySJMESInterface.GetWOCollection("CH");

            lstWorkOrder = new List<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
                lstWorkOrder.Add(dt.Rows[i][0].ToString());
        }

        private void LoadAnimal()
        {
            dicAnimals = new Dictionary<string, string>();
            dicAnimals.Add("鼠", SelfPath + "shu.jpg");
            dicAnimals.Add("牛", SelfPath + "niu.jpg");
            dicAnimals.Add("虎", SelfPath + "hu.jpg");
            dicAnimals.Add("兔", SelfPath + "tu.jpg");
            dicAnimals.Add("龙", SelfPath + "long.jpg");
            dicAnimals.Add("蛇", SelfPath + "she.jpg");
            dicAnimals.Add("马", SelfPath + "ma.jpg");
            dicAnimals.Add("羊", SelfPath + "yang.jpg");
            dicAnimals.Add("猴", SelfPath + "hou.jpg");
            dicAnimals.Add("鸡", SelfPath + "ji.jpg");
            dicAnimals.Add("狗", SelfPath + "gou.jpg");
            dicAnimals.Add("猪", SelfPath + "zhu.jpg");
        }

        #endregion

        #region 图片显示

        private void OnDisplayPic(string path)
        {
            Invoke(new Action<string>((fullPath) =>
            {
                if (string.IsNullOrWhiteSpace(fullPath))
                    picBox.Image = null;
                else
                    picBox.Image = Image.FromFile(path);
            }), path);
        }

        #endregion

        #region 日志显示

        private void ShowClientsMessage(string status, MesSession mesSession)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<string, MesSession>(this.ShowClientsMessage), status, mesSession);
            }
            else
            {
                if (status == "close" && lblDeviceName.Tag.ToString() == mesSession.SessionID)
                {
                    lblDeviceName.Text = "";
                    lblDeviceID.Text = "";
                }
                else if (status == "new")
                {
                    lblDeviceName.Text = "彩盒上料设备";
                    lblDeviceName.Tag = mesSession.SessionID;
                    lblDeviceID.Text = mesSession.RemoteEndPoint.ToString();
                }
            }
        }
        private void ShowSNCheckResult(string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<string>(this.ShowSNCheckResult), msg);
            }
            else
            {
                if (msg == CheckResultCode.OK.ToString())
                    lblSNC.ForeColor = Color.FromArgb(255, 30, 200, 100);
                else
                    lblSNC.ForeColor = Color.Red;
                lblSNC.Text = msg;
            }
        }
        private void ShowMessage(string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<string>(this.ShowMessage), msg);
            }
            else
            {
                log.Info(msg);
                lblInfo.Text = msg;
            }
        }
        private void ShowMessage(IPEndPoint client, string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<IPEndPoint, string>(this.ShowMessage), client, msg);
            }
            else
            {
                log.Info(msg);
                if (msg.Contains("成功"))
                {
                    lblInfo.ForeColor = ColorHelper.MsgGreen;
                }
                else
                {
                    lblInfo.ForeColor = ColorHelper.MsgRed;
                }
                lblInfo.Text = client.ToString() + " " + msg;
            }
        }
        private void ShowMessage(Color color, string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<Color, string>(this.ShowMessage), color, msg);
            }
            else
            {
                log.Info(msg);
                lblInfo.Text = msg;
                lblInfo.ForeColor = color;
            }
        }
        private void ShowConnectionCount(int clientCount)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<int>(this.ShowConnectionCount), clientCount);
            }
            else
            {
                this.toolStripLabel_clientCount.Text = "在线数量： " + clientCount.ToString();
            }
        }

        private void timerDis_Tick(object sender, EventArgs e)
        {
            if (lblInfo.ForeColor != ColorHelper.MsgGray)
            {
                if (DateTime.Now.Second % 2 == 0)
                {
                    lblInfo.Visible = true;
                }
                else
                {
                    lblInfo.Visible = false;
                }
            }
            else
            {
                lblInfo.Visible = true;
            }
        }
        #endregion

        #region 确认

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbWO.SelectedIndex == -1)
            {
                DlgBox.Show("请选择制令单.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvList.Rows.Count == 0)
            {
                DlgBox.Show("待生产工单数量为0.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SendFactory(FunCode.ISR.ToString());

        }

        #endregion

        #region 取消

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (WorkState)
            {
                DialogResult diaR = DlgBox.Show("工单【" + cmbWO.Text + "】正在生产中，是否暂停生产？.", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                ShowMessage(ColorHelper.MsgGray, "工单已暂停.");
                if (diaR == DialogResult.OK)
                {
                    if (WorkStateChange != null)
                    {
                        WorkStateChange.Invoke(false);
                        WorkState = false;
                    }
                }
            }

        }

        #endregion

        #region 选择制令单加载事件

        private void cmbWO_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbWO.SelectedValue != null)
            {
                WorkOrder = cmbWO.SelectedValue.ToString();
                GetBoxInfor(WorkOrder, "");
            }
        }

        private void ClearArea()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate(this.ClearArea));
            }
            else
            {
                dgvList.DataSource = null;
                lblCount.Text = "0";
                lblCountP.Text = "0";
                lblCountU.Text = "0";
                lblSNC.Text = "--/--";
                picBox.Image = null;
            }

        }

        /// <summary>
        /// 查询制令单关联的个性化工单
        /// </summary>
        private void GetBoxInfor(string wo, string sn)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<string, string>(this.GetBoxInfor), wo, sn);
            }
            else
            {
                GetBoxWorkOrderInfo(wo, sn);
            }
        }

        private void GetBoxWorkOrderInfo(string workOrder, string sn)
        {
            try
            {
                ClearArea();

                DataTable dt = new DataTable();
                dt = ySJMESInterface.GetCHWOInfor(workOrder, sn);

                if (dt == null || dt.Rows.Count == 0)
                {
                    HandleStop();
                    ShowMessage(ColorHelper.MsgOrange, "工单已完成，待执行工单数量为 0.");
                    return;
                }
                dgvList.DataSource = dt;
                SerialNumber = dt.Rows[0]["CH_Order"].ToString();
                lblCount.Text = dt.Rows[0]["SumQTY"].ToString();
                lblCountP.Text = dt.Rows[0]["CompleteQTY"].ToString();
                lblCountU.Text = dt.Rows[0]["WaitQTY"].ToString();
                if (!string.IsNullOrWhiteSpace(sn))
                {
                    ShowMessage(ColorHelper.MsgOrange, "请扫描彩盒ID条码");
                }
                else
                {
                    HandleStop();
                    ShowMessage(ColorHelper.MsgGray, "点击确认按钮，锁定工单，并询问设备是否具备开工条件.");
                }
            }
            catch (Exception e)
            {
                ShowMessage(ColorHelper.MsgRed, "工单信息加载错误，" + e.Message);
                return;
            }
        }

        #endregion

        #region 根据盒子属性加载相应图片

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string sType = dgvList.Rows[0].Cells[2].Value.ToString();
                OnDisplayPic(dicAnimals[sType]);
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region 彩盒规格校验

        /// <summary>
        /// 彩盒规格校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void txbBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetBoxSpecCheck(cmbWO.SelectedText, txbBoxID.Text);
            }
        }
        private bool GetBoxSpecCheck(string wo, string boxID)
        {
            try
            {
                string sAtt = dgvList.Rows[0].Cells[2].Value.ToString();
                bool b = ySJMESInterface.CheckBoxAttribut(txbBoxID.Text, sAtt);
                if (b)
                {
                    ShowMessage(ColorHelper.MsgGreen, "彩盒校验成功");
                    SendFactory(FunCode.SND.ToString());
                }
                else
                {
                    ShowMessage(ColorHelper.MsgOrange, "彩盒ID校验失败");
                }
            }
            catch (Exception e)
            {
                ShowMessage(ColorHelper.MsgOrange, "彩盒ID校验失败:" + e.Message);
            }
            return true;
        }

        #endregion

        #region 客户端发送消息

        private void SendFactory(string funCode)
        {
            try
            {
                if (currentMesSession == null)
                {
                    ShowMessage(ColorHelper.MsgOrange, "没有选中任何在线设备！");
                    return;
                }
                if (!currentMesSession.Connected)
                {
                    ShowMessage(ColorHelper.MsgOrange, "目标设备不在线！");
                    return;
                }

                TransmitData tData = null;
                switch (funCode)
                {
                    case "ISR":
                        ShowMessage("询问设备是否具备开工条件.");
                        tData = new TransmitData(WorkOrder, GlobalData.EquipmentNO, null, null, null, null);
                        break;
                    case "SND":
                        ShowMessage("彩盒规格校验ok，下发SN打印.");
                        tData = new TransmitData(WorkOrder, GlobalData.EquipmentNO, SerialNumber, null, null, null);
                        tData.Items.Add("url", GlobalData.URL);
                        break;
                }
                string msg = funCode + GlobalData.SpacePoint + JsonHelper.Serialize(tData) + Environment.NewLine;//一定要加上分隔符 
                byte[] bMsg = System.Text.Encoding.UTF8.GetBytes(msg);//消息使用UTF-8编码
                currentMesSession.Send(new ArraySegment<byte>(bMsg, 0, bMsg.Length));
            }
            catch (Exception ee)
            {
                ShowMessage(ColorHelper.MsgRed, ee.Message);
            }
        }

        #endregion

        #region 获取下一条工单记录（SN）

        /// <summary>
        /// 获取下一条工单记录
        /// </summary>
        /// <param name="wO"></param>
        private void GetNextSN(string wo)
        {
            Thread.Sleep(200);

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<string>(this.GetNextSN), wo);
            }
            else
            {
                ClearArea();

                //------------------------test
                if (cmbWO.SelectedIndex != 0)
                    return;
                txbBoxID.Text = "";
                txbBoxID.Focus();
                GetBoxWorkOrderInfo(wo, SerialNumber);

            }

        }
        #endregion

        #region 状态管理

        /// <summary>
        /// 操作区初始状态
        /// </summary>
        private void HandleInit()
        {
            cmbWO.Enabled = false;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }
        /// <summary>
        /// 操作区工作状态
        /// </summary>
        private void HandleWork()
        {
            cmbWO.Enabled = false;
            btnOK.Enabled = false;
            btnCancel.Enabled = true;
        }
        /// <summary>
        /// 操作区停止状态
        /// </summary>
        private void HandleStop()
        {
            cmbWO.Enabled = true;
            btnOK.Enabled = true;
            btnCancel.Enabled = false;
        }

        public void BtnLock(SkinButton btn)
        {
            btn.Text = "锁定";
            ButtonTheam.OrangeButton(btn);
        }

        public void BtnUnLock(SkinButton btn)
        {
            btn.Text = "解锁";
            ButtonTheam.LightGrayButton(btn);
        }

        private void lblDeviceID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblDeviceID.Text))
            {
                ShowMessage(ColorHelper.MsgOrange, "请选择制令单.");
                HandleStop();
            }
            else
            {
                HandleInit();
            }
        }
        #endregion

        //-------------------------------------------------------------------------
        #region main

        /// <summary>
        /// 使用ping检测网络是否通畅
        /// </summary>
        /// <param name="ip">被测主机IP地址</param>
        /// <returns></returns>
        private void CheckNetConnection(object obj)
        {
            object lockObj = new object();
            string ip = obj as string;
            Ping ping = new Ping();
            while (true)
            {
                try
                {
                    PingReply pingReply_Server = ping.Send(ip, interval); 
                    lock (lockObj)
                    {
                        if (pingReply_Server.Status == IPStatus.Success)
                        {
                            IsConnectionOK = true;
                        }
                        else
                        {
                            IsConnectionOK = false;
                        }
                    }
                }
                catch (Exception)
                {
                    IsConnectionOK = false;
                }
                finally
                {
                    Thread.Sleep(2000);
                }
            }
        }
        /// <summary>
        /// 显示日志信息
        /// </summary>
        /// <param name="msg"></param>
        private void OnDisplayLog(string msg)
        {
            this.Invoke(new Action<string>((message) =>
            {
                rtbLog.AppendText(message);
                rtbLog.ScrollToCaret();
                message = message.Substring(message.IndexOf(">>") + 2);
                message = "信息：" + message.Substring(0, message.LastIndexOf('('));
                staStripNote.Text = message;
            }), msg);
        }
        /// <summary>
        /// 主界面定时器事件
        /// </summary>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            //更新时间
            staStripTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //更新当前操作工
            lblLoginUser.Text = "admin";

            //检查网络连接 
            if (timeCounter % 5 == 0)
            {
                if (IsConnectionOK)
                {
                    if (IsConnectionOK)
                    {
                        CenterImage.Image = Image.FromFile(ExePath + @"Res\Network.png");
                    }
                    else
                    {
                        CenterImage.Image = Image.FromFile(ExePath + @"Res\Network2.png");
                        ShowMessage(ColorHelper.MsgRed,"MES服务网络连接断开...");
                    }
                }
            }
            timeCounter++;
        }
        /// <summary>
        /// 状态条提示文字
        /// </summary>
        private void staStripNote_Click(object sender, EventArgs e)
        {
            staStripShowOutWnd_Click(null, null);
        }
        /// <summary>
        /// 显隐条码和日志窗口
        /// </summary>
        private void staStripShowOutWnd_Click(object sender, EventArgs e)
        {
            tabCtrlBottom.Visible = !tabCtrlBottom.Visible;
            if (tabCtrlBottom.Visible)
            {
                staStripShowOutWnd.Text = " ↓ [条码-日志]";
            }
            else
            {
                staStripShowOutWnd.Text = " ↑ [条码-日志]";
            }
        }

        private void staStripTest2_Click(object sender, EventArgs e)
        {
            MainSplit.Panel1Collapsed = !MainSplit.Panel1Collapsed;
        }

        /// <summary>
        /// 主窗口关闭处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = DlgBox.Show("确定退出本系统吗", "退出系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                log.OnDisplayLog -= OnDisplayLog;
            }
        }

        #endregion



    }
}
