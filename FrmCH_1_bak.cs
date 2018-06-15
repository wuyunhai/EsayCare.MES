using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using DM_API;
using System.Collections.Concurrent;
using YSJ_IAAPI;
using CCWin.SkinControl;
using System.ComponentModel;

namespace EsayCare.MES
{

    public partial class FrmCH_1_bak : Form 
    {
        #region var

        #region CH_var

        private int interval = 300;
        private bool CHDriver_WorkState;
        private YSJMESInterface ySJMESInterface;
        private DM_SFCInterface SFCInterface;
        private List<string> lstWorkOrder;
        private Dictionary<string, string> dicAnimals;
        public static ConcurrentDictionary<string, MesSession> mOnLineConnections = new ConcurrentDictionary<string, MesSession>();

        public string WorkOrder;
        public string SerialNumber;

        Queue<Func<ErrorMessage>> CheckQueue = new Queue<Func<ErrorMessage>>();

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

        public FrmCH_1_bak()
        {
            InitializeComponent();
             
        }

        #endregion

        #region 窗体载入

        private void FormMain_Load(object sender, EventArgs e)
        {
            #region CH 

            if (GlobalData.currentMesSession != null)
            {
                DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "请选择制令单.");
                HandleStop();
            }
            else
            {
                HandleInit();
            }

            CheckQueue = new Queue<Func<ErrorMessage>>();
            CheckQueue.Enqueue(LoadAnimalPic);

            cPnlHandle.ColorTable = GlobalData.PnlColor;
            cPnlPicView.ColorTable = GlobalData.PnlColor;
            cPnlWorkOrder.ColorTable = GlobalData.PnlColor;

            DelegateState.CHDriverWorkStateChange = CHDriver_WorkStateChange;
            DelegateState.NewSessionConnected += NewSessionConnected;
            DelegateState.SessionClosed += SessionClosed;

            dgvList.AutoGenerateColumns = false;
            SFCInterface = new DM_SFCInterface();
            ySJMESInterface = new YSJMESInterface();

            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += AsyncLoadUIPluguns;
            bgw.RunWorkerCompleted += AsyncLoadUIPlugunsCompleted;
            bgw.RunWorkerAsync();//开启异步加载插件模块 

            #endregion
        }

        private void AsyncLoadUIPlugunsCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmbWorkOrder.ValueMember = "WorkOrder";
            cmbWorkOrder.DataSource = lstWorkOrder;
            cmbWorkOrder.SelectedIndex = -1;
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
                    DelegateState.MsgView?.Invoke(ColorHelper.MsgRed, errMsg.ToString());
                    break;
                }
            }
        }

        private void CHDriver_WorkStateChange(bool isWorking)
        {
            SetCHDriver_WorkState(isWorking);
        }

        private void SetCHDriver_WorkState(bool isWorking)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<bool>(this.SetCHDriver_WorkState), isWorking);
            }
            else
            {
                CHDriver_WorkState = isWorking;
                if (isWorking)
                    HandleWork();
                else
                    HandleStop();
            }
        }

        #endregion

        #region MesServer相关


        // 连接关闭
        private void SessionClosed(MesSession session, global::SuperSocket.SocketBase.CloseReason value)
        {
            HandleInit();
        }

        //新的连接
        private void NewSessionConnected(MesSession session)
        {
            DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "请选择制令单.");
            HandleStop();
        }

        #endregion

        #region 查询彩盒制令单

        /// <summary>
        /// 查询彩盒制令单
        /// </summary>
        /// <param name="v"></param>
        private ErrorMessage GetWorkOrder()
        {
            DelegateState.MsgView?.Invoke(ColorHelper.MsgGray, "加载彩盒工单...");
            Thread.Sleep(interval);
            try
            {
                DataTable dt = new DataTable();
                dt = ySJMESInterface.GetWOCollection("CH");

                lstWorkOrder = new List<string>();

                for (int i = 0; i < dt.Rows.Count; i++)
                    lstWorkOrder.Add(dt.Rows[i][0].ToString());
            }
            catch (Exception e)
            {
                return new ErrorMessage() { ErrorCode = "LoadAnimalPic", ErrorInfo = e.Message };
            }
            return null;
        }

        #region 加载生肖图片

        private ErrorMessage LoadAnimalPic()
        {
            DelegateState.MsgView?.Invoke(ColorHelper.MsgGray, "加载彩盒生肖图片...");
            Thread.Sleep(interval);
            try
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
            catch (Exception e)
            {
                return new ErrorMessage() { ErrorCode = "LoadAnimalPic", ErrorInfo = e.Message };
            }
            return null;
        }

        #endregion

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

        private void ShowSNCheckResult(string msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(this.ShowSNCheckResult), msg);
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

        #endregion

        #region 确认

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbWorkOrder.SelectedIndex == -1)
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
            if (CHDriver_WorkState)
            {
                DialogResult diaR = DlgBox.Show("工单【" + cmbWorkOrder.Text + "】正在生产中，是否暂停生产？.", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (diaR == DialogResult.OK)
                {
                    DelegateState.MsgView?.Invoke(ColorHelper.MsgGray, "工单已暂停...");
                    DelegateState.CHDriverWorkStateChange?.Invoke(false);
                    CHDriver_WorkState = false;
                }
            }
        }

        #endregion

        #region 选择制令单加载事件
        private void cmbWO_DropDown(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ySJMESInterface.GetWOCollection("CH");

                lstWorkOrder = new List<string>();

                for (int i = 0; i < dt.Rows.Count; i++)
                    lstWorkOrder.Add(dt.Rows[i][0].ToString());

                cmbWorkOrder.ValueMember = "WorkOrder";
                cmbWorkOrder.DataSource = lstWorkOrder;
            }
            catch (Exception ex)
            {
                DelegateState.MsgView?.Invoke(ColorHelper.MsgRed, ex.Message);
            }
        }
        private void cmbWO_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbWorkOrder.SelectedValue != null)
            {
                WorkOrder = cmbWorkOrder.SelectedValue.ToString();
                GetBoxInfor(WorkOrder, "");
            }
        }

        private void ClearArea()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(this.ClearArea));
            }
            else
            {
                dgvList.DataSource = null;
                lblCount.Text = "0";
                lblCountP.Text = "0";
                lblCountU.Text = "0";
                lblSNC.Text = "";
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
                this.BeginInvoke(new Action<string, string>(this.GetBoxInfor), wo, sn);
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
                    DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "工单已完成，待执行工单数量为 0.");
                    return;
                }
                dgvList.DataSource = dt;
                SerialNumber = dt.Rows[0]["CH_Order"].ToString();
                lblCount.Text = dt.Rows[0]["SumQTY"].ToString();
                lblCountP.Text = dt.Rows[0]["CompleteQTY"].ToString();
                lblCountU.Text = dt.Rows[0]["WaitQTY"].ToString();
                if (!string.IsNullOrWhiteSpace(sn))
                {
                    DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "请扫描彩盒ID条码");
                }
                else
                {
                    HandleStop();
                    DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "点击确认按钮，锁定工单，并询问设备是否具备开工条件.");
                }
            }
            catch (Exception e)
            {
                DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "工单信息加载错误，" + e.Message);
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
                GetBoxSpecCheck(cmbWorkOrder.SelectedText, txbBoxID.Text);
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
                    DelegateState.MsgView?.Invoke(ColorHelper.MsgGreen, "彩盒校验成功");
                    SendFactory(FunCode.SND.ToString());
                }
                else
                {
                    DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "彩盒ID校验失败");
                }
            }
            catch (Exception e)
            {
                DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "彩盒ID校验失败:" + e.Message);
            }
            return true;
        }

        #endregion

        #region 客户端发送消息

        private void SendFactory(string funCode)
        {
            try
            {
                if (GlobalData.currentMesSession == null)
                {
                    DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "没有选中任何在线设备！");
                    return;
                }
                if (!GlobalData.currentMesSession.Connected)
                {
                    DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "目标设备不在线！");
                    return;
                }

                TransmitData tData = null;
                switch (funCode)
                {
                    case "ISR":
                        DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "询问设备是否具备开工条件.");
                        tData = new TransmitData(WorkOrder, GlobalData.CH_1_DeviceID, null, null, null, null);
                        break;
                    case "SND":
                        DelegateState.MsgView?.Invoke(ColorHelper.MsgOrange, "彩盒规格校验ok，下发SN打印.");
                        tData = new TransmitData(WorkOrder, GlobalData.CH_1_DeviceID, SerialNumber, null, null, null);
                        tData.TestItems.Add("url", GlobalData.URL);
                        break;
                }
                string msg = funCode + " " + JsonHelper.Serialize(tData) + Environment.NewLine;//一定要加上分隔符 
                byte[] bMsg = System.Text.Encoding.UTF8.GetBytes(msg);//消息使用UTF-8编码
                GlobalData.currentMesSession.Send(new ArraySegment<byte>(bMsg, 0, bMsg.Length));
            }
            catch (Exception ee)
            {
                DelegateState.MsgView?.Invoke(ColorHelper.MsgRed, ee.Message);
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
                this.BeginInvoke(new Action<string>(this.GetNextSN), wo);
            }
            else
            {
                ClearArea();

                //------------------------test
                if (cmbWorkOrder.SelectedIndex != 0)
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
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(HandleInit));
            }
            else
            {
                cmbWorkOrder.Enabled = false;
                btnOK.Enabled = false;
                btnCancel.Enabled = false;
            }
        }
        /// <summary>
        /// 操作区工作状态
        /// </summary>
        private void HandleWork()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(HandleWork));
            }
            else
            {
                cmbWorkOrder.Enabled = false;
                btnOK.Enabled = false;
                btnCancel.Enabled = true;
            }
        }
        /// <summary>
        /// 操作区停止状态
        /// </summary>
        private void HandleStop()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(HandleStop));
            }
            else
            {
                cmbWorkOrder.Enabled = true;
                btnOK.Enabled = true;
                btnCancel.Enabled = false;
            }
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


        #endregion

    }
}
