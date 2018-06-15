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

    public partial class FrmMain : Skin_Metro
    {
        #region var 

        private int interval = 300; //定时时间间隔
        private long timeCounter;    //计时数 
        private LogHelper log;      //日志记录助手
        private bool IsConnectionOK = false;                                            //标识网络是否通畅 
        private string ExePath = AppDomain.CurrentDomain.BaseDirectory;                 //可执行文件路径  
        private Queue<Func<ErrorMessage>> CheckQueue = new Queue<Func<ErrorMessage>>(); //校验方法队列

        #endregion


        #region 构造函数

        public FrmMain()
        {
            InitializeComponent();

            cpnl.ColorTable = GlobalData.PnlColorTable; ;
            skinPushPanel1.ColorTable = GlobalData.PnlColorTable; ;

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
            //初始化全局数据 
            GlobalData.InitGlobalData();
            log = GlobalData.Log;
            log.OnDisplayLog += OnDisplayLog;
            CenterImage.Image = Image.FromFile(ExePath + @"Res\Network2.png");
            Text = string.Format("IA-MES CS端系统 ({0} - {1})", GlobalData.Process, GlobalData.MachineId);
            staStripVersion.Text = "版本：" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lstMenu.SelectedIndex = 0;

            CheckQueue = new Queue<Func<ErrorMessage>>();
            CheckQueue.Enqueue(CheckConnection);
            CheckQueue.Enqueue(InitMesServer);

            // 各种委托回调
            DelegateState.MsgView = ShowMessage;
            DelegateState.NewRequestReceived = ShowMessage;
            DelegateState.NewSessionConnected += NewSessionConnected;
            DelegateState.SessionClosed += SessionClosed;

            //开启异步校验
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += AsyncLoadUIPluguns;
            bgw.RunWorkerCompleted += AsyncLoadUIPlugunsCompleted;
            bgw.RunWorkerAsync();

            //启动网络连接监测线程
            Thread threadPing = new Thread(CheckNetConnection);
            threadPing.IsBackground = true;
            threadPing.Priority = ThreadPriority.Lowest;
            threadPing.Start(GlobalData.MESServerIP);

            busyCon.BringToFront();
        }

        private void AsyncLoadUIPlugunsCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            busyCon.Style = ProgressBarStyle.Continuous;
            busyCon.Visible = false;
        }

        private void AsyncLoadUIPluguns(object sender, DoWorkEventArgs e)
        {
            ErrorMessage errMsg = null;
            var count = CheckQueue.Count;
            for (int index = 0; index < count; index++)
            {
                var checkMethod = CheckQueue.Dequeue();
                errMsg = checkMethod();
                if (errMsg != null)
                {
                    ShowMessage(ColorHelper.MsgRed, errMsg.ToString());
                    break;
                }
            }
        }

        // 检查网络连接
        private ErrorMessage CheckConnection()
        {
            ShowMessage(ColorHelper.MsgGray, "正在检查MES-EQC服务器网络连接...");
            Thread.Sleep(interval);

            Ping ping = new Ping();
            try
            {
                PingReply pingMES = ping.Send(GlobalData.MESServerIP, interval);
                if (pingMES.Status != IPStatus.Success)
                    return new ErrorMessage() { ErrorCode = pingMES.Status.ToString(), ErrorInfo = "MES服务器网络连接故障..." };

                PingReply pingEQC = ping.Send(GlobalData.EQCServerIP, interval);
                if (pingMES.Status != IPStatus.Success)
                    return new ErrorMessage() { ErrorCode = pingMES.Status.ToString(), ErrorInfo = "EQC服务器网络连接故障..." };
            }
            catch (Exception e)
            {
                return new ErrorMessage() { ErrorCode = "Error_MES-EQC", ErrorInfo = e.Message };
            }
            return null;
        }

        #endregion

        #region MesServer相关

        // 初始服务
        private ErrorMessage InitMesServer()
        {
            ShowMessage(ColorHelper.MsgGray, "正在加载通讯服务...");
            Thread.Sleep(interval);
            try
            {
                //=>方法一、采用当前应用程序中的【App.config】文件BootstrapFactory.CreateBootstrap()。方法二、采用自定义独立【SuperSocket.config】配置文件
                var bootstrap = BootstrapFactory.CreateBootstrapFromConfigFile("SuperSocket.config");
                if (!bootstrap.Initialize())
                    return new ErrorMessage() { ErrorCode = "Init Error", ErrorInfo = "Failed to initialize!" };

                StartResult startResult = bootstrap.Start();
                if (startResult == StartResult.Success)
                {
                    this.ShowMessage(ColorHelper.MsgGreen, "服务启动成功，等待设备连接 =>");
                }
                else
                    return new ErrorMessage() { ErrorCode = "StartError", ErrorInfo = "服务启动失败!" };
            }
            catch (Exception ex)
            {
                return new ErrorMessage() { ErrorCode = "StartError", ErrorInfo = ex.Message };
            }
            return null;
        }

        // 连接关闭
        private void SessionClosed(MesSession session, global::SuperSocket.SocketBase.CloseReason value)
        {
            ShowMessage(ColorHelper.MsgRed, session.RemoteEndPoint + " 断开连接！");
            ShowDeviceInfo("close", session);
        }

        // 新的连接
        private void NewSessionConnected(MesSession session)
        {
            ShowMessage(ColorHelper.MsgGreen, session.RemoteEndPoint + " 连接成功！");
            ShowDeviceInfo("new", session);
        }

        #endregion

        #region 消息显示

        // 设备连接信息
        private void ShowDeviceInfo(string status, MesSession mesSession)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string, MesSession>(this.ShowDeviceInfo), status, mesSession);
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

        // 操作提醒信息
        private void ShowMessage(Color color, string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<Color, string>(this.ShowMessage), color, msg);
            }
            else
            {
                log.Info(msg);
                lblInfo.Text = msg;
                lblInfo.ForeColor = color;
            }
        }
        private void ShowMessage(MesSession mesSession, MesRequestInfo requestInfo)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<MesSession, MesRequestInfo>(this.ShowMessage), mesSession, requestInfo);
            }
            else
            {
                ShowMessage(requestInfo.MsgColor, requestInfo.Msg);
            }
        }

        // 关键信息闪烁提示
        private void timerDis_Tick(object sender, EventArgs e)
        {
            if (lblInfo.ForeColor != ColorHelper.MsgGray)
            {
                if (DateTime.Now.Second % 2 == 0)
                    lblInfo.Visible = true;
                else
                    lblInfo.Visible = false;
            }
            else
            {
                lblInfo.Visible = true;
            }
        }
        #endregion

        #region main

        // 菜单选择事件
        private void skinListBox_Click(object sender, EventArgs e)
        {
            SkinListBox slistBox = sender as SkinListBox;

            if (slistBox.SelectedItem != null)
            {
                string menuText = slistBox.SelectedItem.ToString();
                foreach (SkinTabPage item in tabControl.TabPages)
                {
                    if (item.Text == menuText)
                    {
                        tabControl.SelectedTab = item;
                        return;
                    }
                }
                SkinTabPage tabPag = null;
                switch (menuText)
                {
                    #region 系统管理

                    case "彩盒上料":
                        //当前窗口设置成mdi容器  
                        FrmCH_1 frmCH_1 = new FrmCH_1();
                        //frmCH_1.MdiParent = this;
                        frmCH_1.Text = menuText;
                        frmCH_1.TopLevel = false;
                        frmCH_1.Dock = DockStyle.Fill;
                        tabPag = new SkinTabPage(menuText);
                        tabPag.Validating += TabPag_Validating;
                        //设置父窗体为panel  
                        //frmCH_1.Parent = tabPag;

                        tabPag.Controls.Add(frmCH_1);
                        tabControl.Controls.Add(tabPag);

                        frmCH_1.Show();
                        break;

                        #endregion

                }
                tabControl.SelectedTab = tabPag;
            }
        }

        private void TabPag_Validating(object sender, CancelEventArgs e)
        {
          
        }

        // 使用ping检测网络是否通畅
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
                            IsConnectionOK = true;
                        else
                            IsConnectionOK = false;
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

        // 显示日志信息
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

        // 主界面定时器事件
        private void timerMain_Tick(object sender, EventArgs e)
        {
            staStripTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //检查网络连接 
            if (timeCounter % 5 == 0)
            {
                if (IsConnectionOK)
                {
                    CenterImage.Image = Image.FromFile(ExePath + @"Res\Network.png");
                }
                else
                {
                    CenterImage.Image = Image.FromFile(ExePath + @"Res\Network2.png");
                    ShowMessage(ColorHelper.MsgRed, "MES服务网络连接断开...");
                }
            }
            timeCounter++;
        }

        // 条码和日志隐藏/显示
        private void staStripShowOutWnd_Click(object sender, EventArgs e)
        {
            splitContent.Panel2Collapsed = !splitContent.Panel2Collapsed;

            if (splitContent.Panel2Collapsed)
                staStripShowOutWnd.Text = " ↓ [条码-日志]";
            else
                staStripShowOutWnd.Text = " ↑ [条码-日志]";
        }

        //左侧菜单隐藏/显示
        private void logoPic_Click(object sender, EventArgs e)
        {
            staStripTest2_Click(null, null);
        }
        private void staStripTest2_Click(object sender, EventArgs e)
        {
            MainSplit.Panel1Collapsed = !MainSplit.Panel1Collapsed;
        }

        // 主窗口关闭处理
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

        private void tabControl_TabePageClosed(object sender, TabPageEventArgs e)
        {

        }


        private void tabControl_TabePageClosing(object sender, TabPageEventArgs e)
        {
            
            if (e.ColseTabPage.Text.Equals(GlobalData.Process))
            {
                DlgBox.Show("禁止关闭当前页面.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CancelEventArgs e1 = new CancelEventArgs();
                e1.Cancel = true;
                TabPag_Validating(e.ColseTabPage, e1);
                return;
            }
        }
    }
}
