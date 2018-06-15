
namespace EsayCare.MES
{
    partial class FrmCH_1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCH_1));
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.MainSplit = new CCWin.SkinControl.SkinSplitContainer();
            this.skinPanel5 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel6 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.lblSN = new CCWin.SkinControl.SkinLabel();
            this.skinPanel4 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.lblType = new CCWin.SkinControl.SkinLabel();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.lblPro = new CCWin.SkinControl.SkinLabel();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.picBox = new CCWin.SkinControl.SkinPictureBox();
            this.cPnlHandle = new CCWin.SkinControl.SkinPanel();
            this.txbBoxID = new CCWin.SkinControl.SkinTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbWorkOrder = new MetroFramework.Controls.MetroComboBox();
            this.cpbCountU = new CircularProgressBar.CircularProgressBar();
            this.cpbCountP = new CircularProgressBar.CircularProgressBar();
            this.cpbCount = new CircularProgressBar.CircularProgressBar();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.lblSNC = new CCWin.SkinControl.SkinLabel();
            this.timerDis = new System.Windows.Forms.Timer(this.components);
            this.skinAnimator1 = new CCWin.SkinControl.SkinAnimator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.skinPanel5.SuspendLayout();
            this.skinPanel6.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.skinPanel4.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.cPnlHandle.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplit
            // 
            this.MainSplit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinAnimator1.SetDecoration(this.MainSplit, CCWin.SkinControl.DecorationType.None);
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplit.IsSplitterFixed = true;
            this.MainSplit.Location = new System.Drawing.Point(2, 0);
            this.MainSplit.Margin = new System.Windows.Forms.Padding(0);
            this.MainSplit.Name = "MainSplit";
            this.MainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplit.Panel1
            // 
            this.skinAnimator1.SetDecoration(this.MainSplit.Panel1, CCWin.SkinControl.DecorationType.None);
            this.MainSplit.Panel1Collapsed = true;
            this.MainSplit.Panel1MinSize = 1;
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.BackColor = System.Drawing.Color.White;
            this.MainSplit.Panel2.Controls.Add(this.skinPanel5);
            this.skinAnimator1.SetDecoration(this.MainSplit.Panel2, CCWin.SkinControl.DecorationType.None);
            this.MainSplit.Panel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.MainSplit.Size = new System.Drawing.Size(1141, 652);
            this.MainSplit.SplitterDistance = 25;
            this.MainSplit.SplitterWidth = 1;
            this.MainSplit.TabIndex = 5;
            this.MainSplit.TabStop = false;
            // 
            // skinPanel5
            // 
            this.skinPanel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel5.Controls.Add(this.skinPanel6);
            this.skinPanel5.Controls.Add(this.skinPanel2);
            this.skinPanel5.Controls.Add(this.cPnlHandle);
            this.skinPanel5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.skinPanel5, CCWin.SkinControl.DecorationType.None);
            this.skinPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel5.DownBack = null;
            this.skinPanel5.Location = new System.Drawing.Point(0, 0);
            this.skinPanel5.MouseBack = null;
            this.skinPanel5.Name = "skinPanel5";
            this.skinPanel5.NormlBack = null;
            this.skinPanel5.Size = new System.Drawing.Size(1141, 652);
            this.skinPanel5.TabIndex = 3;
            // 
            // skinPanel6
            // 
            this.skinPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.skinPanel6.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel6.Controls.Add(this.skinPanel1);
            this.skinPanel6.Controls.Add(this.skinPanel4);
            this.skinPanel6.Controls.Add(this.skinPanel3);
            this.skinPanel6.Controls.Add(this.btnCancel);
            this.skinPanel6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.skinPanel6, CCWin.SkinControl.DecorationType.None);
            this.skinPanel6.DownBack = ((System.Drawing.Image)(resources.GetObject("skinPanel6.DownBack")));
            this.skinPanel6.ForeColor = System.Drawing.Color.Crimson;
            this.skinPanel6.Location = new System.Drawing.Point(1, 159);
            this.skinPanel6.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinPanel6.MouseBack")));
            this.skinPanel6.Name = "skinPanel6";
            this.skinPanel6.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinPanel6.NormlBack")));
            this.skinPanel6.Size = new System.Drawing.Size(491, 493);
            this.skinPanel6.TabIndex = 78;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.skinPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.lblSN);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.skinPanel1, CCWin.SkinControl.DecorationType.None);
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(22, 213);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Radius = 15;
            this.skinPanel1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel1.Size = new System.Drawing.Size(445, 86);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinAnimator1.SetDecoration(this.skinLabel2, CCWin.SkinControl.DecorationType.None);
            this.skinLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.skinLabel2.ForeColor = System.Drawing.Color.Silver;
            this.skinLabel2.Location = new System.Drawing.Point(380, 69);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(48, 15);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "彩盒SN";
            // 
            // lblSN
            // 
            this.lblSN.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Relievo;
            this.lblSN.AutoSize = true;
            this.lblSN.BackColor = System.Drawing.Color.Transparent;
            this.lblSN.BorderColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.lblSN, CCWin.SkinControl.DecorationType.None);
            this.lblSN.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.lblSN.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblSN.Location = new System.Drawing.Point(9, 12);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(295, 40);
            this.lblSN.TabIndex = 0;
            this.lblSN.Text = "CH895673254789";
            // 
            // skinPanel4
            // 
            this.skinPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.skinPanel4.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel4.Controls.Add(this.skinLabel8);
            this.skinPanel4.Controls.Add(this.lblType);
            this.skinPanel4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.skinPanel4, CCWin.SkinControl.DecorationType.None);
            this.skinPanel4.DownBack = null;
            this.skinPanel4.Location = new System.Drawing.Point(22, 121);
            this.skinPanel4.MouseBack = null;
            this.skinPanel4.Name = "skinPanel4";
            this.skinPanel4.NormlBack = null;
            this.skinPanel4.Radius = 15;
            this.skinPanel4.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel4.Size = new System.Drawing.Size(445, 86);
            this.skinPanel4.TabIndex = 3;
            // 
            // skinLabel8
            // 
            this.skinLabel8.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinAnimator1.SetDecoration(this.skinLabel8, CCWin.SkinControl.DecorationType.None);
            this.skinLabel8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.skinLabel8.ForeColor = System.Drawing.Color.White;
            this.skinLabel8.Location = new System.Drawing.Point(380, 69);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(55, 15);
            this.skinLabel8.TabIndex = 1;
            this.skinLabel8.Text = "彩盒类型";
            // 
            // lblType
            // 
            this.lblType.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Relievo;
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.BorderColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.lblType, CCWin.SkinControl.DecorationType.None);
            this.lblType.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblType.Location = new System.Drawing.Point(10, 14);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(104, 40);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "50 ml";
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(220)))), ((int)(((byte)(100)))));
            this.skinPanel3.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel3.Controls.Add(this.skinLabel3);
            this.skinPanel3.Controls.Add(this.lblPro);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.skinPanel3, CCWin.SkinControl.DecorationType.None);
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(22, 29);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Radius = 15;
            this.skinPanel3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel3.Size = new System.Drawing.Size(445, 86);
            this.skinPanel3.TabIndex = 2;
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinAnimator1.SetDecoration(this.skinLabel3, CCWin.SkinControl.DecorationType.None);
            this.skinLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.skinLabel3.ForeColor = System.Drawing.Color.White;
            this.skinLabel3.Location = new System.Drawing.Point(380, 66);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(55, 15);
            this.skinLabel3.TabIndex = 1;
            this.skinLabel3.Text = "彩盒属性";
            // 
            // lblPro
            // 
            this.lblPro.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.Relievo;
            this.lblPro.AutoSize = true;
            this.lblPro.BackColor = System.Drawing.Color.Transparent;
            this.lblPro.BorderColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.lblPro, CCWin.SkinControl.DecorationType.None);
            this.lblPro.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.lblPro.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPro.Location = new System.Drawing.Point(9, 17);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(52, 40);
            this.lblPro.TabIndex = 0;
            this.lblPro.Text = "虎";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Red;
            this.btnCancel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.btnCancel, CCWin.SkinControl.DecorationType.None);
            this.btnCancel.DownBack = null;
            this.btnCancel.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.IsDrawBorder = false;
            this.btnCancel.Location = new System.Drawing.Point(334, 314);
            this.btnCancel.MouseBack = null;
            this.btnCancel.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Radius = 4;
            this.btnCancel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnCancel.Size = new System.Drawing.Size(133, 52);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "Stop";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // skinPanel2
            // 
            this.skinPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.picBox);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.skinPanel2, CCWin.SkinControl.DecorationType.None);
            this.skinPanel2.DownBack = ((System.Drawing.Image)(resources.GetObject("skinPanel2.DownBack")));
            this.skinPanel2.Location = new System.Drawing.Point(488, 159);
            this.skinPanel2.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinPanel2.MouseBack")));
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinPanel2.NormlBack")));
            this.skinPanel2.Size = new System.Drawing.Size(653, 493);
            this.skinPanel2.TabIndex = 77;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.picBox, CCWin.SkinControl.DecorationType.None);
            this.picBox.Location = new System.Drawing.Point(41, 29);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(480, 272);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // cPnlHandle
            // 
            this.cPnlHandle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cPnlHandle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cPnlHandle.BorderColor = System.Drawing.Color.White;
            this.cPnlHandle.Controls.Add(this.txbBoxID);
            this.cPnlHandle.Controls.Add(this.linkLabel1);
            this.cPnlHandle.Controls.Add(this.cmbWorkOrder);
            this.cPnlHandle.Controls.Add(this.cpbCountU);
            this.cPnlHandle.Controls.Add(this.cpbCountP);
            this.cPnlHandle.Controls.Add(this.cpbCount);
            this.cPnlHandle.Controls.Add(this.btnOK);
            this.cPnlHandle.Controls.Add(this.lblSNC);
            this.cPnlHandle.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.cPnlHandle, CCWin.SkinControl.DecorationType.None);
            this.cPnlHandle.DownBack = ((System.Drawing.Image)(resources.GetObject("cPnlHandle.DownBack")));
            this.cPnlHandle.ForeColor = System.Drawing.Color.DarkGray;
            this.cPnlHandle.Location = new System.Drawing.Point(1, 0);
            this.cPnlHandle.MouseBack = ((System.Drawing.Image)(resources.GetObject("cPnlHandle.MouseBack")));
            this.cPnlHandle.Name = "cPnlHandle";
            this.cPnlHandle.NormlBack = ((System.Drawing.Image)(resources.GetObject("cPnlHandle.NormlBack")));
            this.cPnlHandle.Palace = true;
            this.cPnlHandle.Size = new System.Drawing.Size(1141, 162);
            this.cPnlHandle.TabIndex = 76;
            this.cPnlHandle.Text = "彩盒上料";
            // 
            // txbBoxID
            // 
            this.txbBoxID.BackColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.txbBoxID, CCWin.SkinControl.DecorationType.None);
            this.txbBoxID.DownBack = null;
            this.txbBoxID.Icon = ((System.Drawing.Image)(resources.GetObject("txbBoxID.Icon")));
            this.txbBoxID.IconIsButton = false;
            this.txbBoxID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txbBoxID.IsPasswordChat = '\0';
            this.txbBoxID.IsSystemPasswordChar = false;
            this.txbBoxID.Lines = new string[] {
        "BOXID198909290015"};
            this.txbBoxID.Location = new System.Drawing.Point(26, 67);
            this.txbBoxID.Margin = new System.Windows.Forms.Padding(0);
            this.txbBoxID.MaxLength = 32767;
            this.txbBoxID.MinimumSize = new System.Drawing.Size(28, 28);
            this.txbBoxID.MouseBack = null;
            this.txbBoxID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txbBoxID.Multiline = true;
            this.txbBoxID.Name = "txbBoxID";
            this.txbBoxID.NormlBack = null;
            this.txbBoxID.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.txbBoxID.ReadOnly = false;
            this.txbBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBoxID.Size = new System.Drawing.Size(396, 56);
            // 
            // 
            // 
            this.txbBoxID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBoxID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbBoxID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 25F, System.Drawing.FontStyle.Bold);
            this.txbBoxID.SkinTxt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbBoxID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txbBoxID.SkinTxt.Multiline = true;
            this.txbBoxID.SkinTxt.Name = "BaseText";
            this.txbBoxID.SkinTxt.Size = new System.Drawing.Size(363, 46);
            this.txbBoxID.SkinTxt.TabIndex = 0;
            this.txbBoxID.SkinTxt.Text = "BOXID198909290015";
            this.txbBoxID.SkinTxt.WaterColor = System.Drawing.Color.Gainsboro;
            this.txbBoxID.SkinTxt.WaterText = "彩盒ID扫描区";
            this.txbBoxID.TabIndex = 94;
            this.txbBoxID.Text = "BOXID198909290015";
            this.txbBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbBoxID.WaterColor = System.Drawing.Color.Gainsboro;
            this.txbBoxID.WaterText = "彩盒ID扫描区";
            this.txbBoxID.WordWrap = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SlateBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.linkLabel1, CCWin.SkinControl.DecorationType.None);
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.SlateBlue;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(306, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 17);
            this.linkLabel1.TabIndex = 89;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "当前设备执行制令单";
            // 
            // cmbWorkOrder
            // 
            this.skinAnimator1.SetDecoration(this.cmbWorkOrder, CCWin.SkinControl.DecorationType.None);
            this.cmbWorkOrder.Enabled = false;
            this.cmbWorkOrder.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cmbWorkOrder.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbWorkOrder.ItemHeight = 23;
            this.cmbWorkOrder.Location = new System.Drawing.Point(26, 35);
            this.cmbWorkOrder.Name = "cmbWorkOrder";
            this.cmbWorkOrder.PromptText = "选择制令单√";
            this.cmbWorkOrder.Size = new System.Drawing.Size(396, 29);
            this.cmbWorkOrder.Style = MetroFramework.MetroColorStyle.Black;
            this.cmbWorkOrder.TabIndex = 0;
            this.cmbWorkOrder.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmbWorkOrder.UseCustomBackColor = true;
            this.cmbWorkOrder.UseCustomForeColor = true;
            this.cmbWorkOrder.UseSelectable = true;
            this.cmbWorkOrder.UseStyleColors = true;
            this.cmbWorkOrder.DropDownClosed += new System.EventHandler(this.cmbWO_DropDownClosed);
            // 
            // cpbCountU
            // 
            this.cpbCountU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpbCountU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbCountU.AnimationSpeed = 500;
            this.cpbCountU.BackColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.cpbCountU, CCWin.SkinControl.DecorationType.None);
            this.cpbCountU.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.cpbCountU.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cpbCountU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cpbCountU.InnerMargin = 0;
            this.cpbCountU.InnerWidth = -1;
            this.cpbCountU.Location = new System.Drawing.Point(1019, 18);
            this.cpbCountU.MarqueeAnimationSpeed = 2000;
            this.cpbCountU.Name = "cpbCountU";
            this.cpbCountU.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.cpbCountU.OuterMargin = -15;
            this.cpbCountU.OuterWidth = 16;
            this.cpbCountU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbCountU.ProgressWidth = 15;
            this.cpbCountU.SecondaryFont = new System.Drawing.Font("宋体", 36F);
            this.cpbCountU.Size = new System.Drawing.Size(104, 101);
            this.cpbCountU.StartAngle = 270;
            this.cpbCountU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCountU.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbCountU.SubscriptText = "";
            this.cpbCountU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCountU.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbCountU.SuperscriptText = "";
            this.cpbCountU.TabIndex = 85;
            this.cpbCountU.Text = "40";
            this.cpbCountU.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cpbCountU.Value = 40;
            this.cpbCountU.Click += new System.EventHandler(this.cpbCount_Click);
            // 
            // cpbCountP
            // 
            this.cpbCountP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpbCountP.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbCountP.AnimationSpeed = 500;
            this.cpbCountP.BackColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.cpbCountP, CCWin.SkinControl.DecorationType.None);
            this.cpbCountP.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.cpbCountP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cpbCountP.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cpbCountP.InnerMargin = 0;
            this.cpbCountP.InnerWidth = -1;
            this.cpbCountP.Location = new System.Drawing.Point(882, 18);
            this.cpbCountP.MarqueeAnimationSpeed = 2000;
            this.cpbCountP.Name = "cpbCountP";
            this.cpbCountP.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.cpbCountP.OuterMargin = -15;
            this.cpbCountP.OuterWidth = 16;
            this.cpbCountP.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.cpbCountP.ProgressWidth = 15;
            this.cpbCountP.SecondaryFont = new System.Drawing.Font("宋体", 36F);
            this.cpbCountP.Size = new System.Drawing.Size(104, 101);
            this.cpbCountP.StartAngle = 270;
            this.cpbCountP.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCountP.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbCountP.SubscriptText = "";
            this.cpbCountP.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCountP.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbCountP.SuperscriptText = "";
            this.cpbCountP.TabIndex = 84;
            this.cpbCountP.Text = "60";
            this.cpbCountP.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cpbCountP.Value = 60;
            this.cpbCountP.Click += new System.EventHandler(this.cpbCount_Click);
            // 
            // cpbCount
            // 
            this.cpbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpbCount.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbCount.AnimationSpeed = 500;
            this.cpbCount.BackColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.cpbCount, CCWin.SkinControl.DecorationType.Custom);
            this.cpbCount.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.cpbCount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cpbCount.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.cpbCount.InnerMargin = 0;
            this.cpbCount.InnerWidth = -1;
            this.cpbCount.Location = new System.Drawing.Point(745, 18);
            this.cpbCount.MarqueeAnimationSpeed = 2000;
            this.cpbCount.Name = "cpbCount";
            this.cpbCount.OuterColor = System.Drawing.Color.WhiteSmoke;
            this.cpbCount.OuterMargin = -15;
            this.cpbCount.OuterWidth = 16;
            this.cpbCount.ProgressColor = System.Drawing.Color.SlateBlue;
            this.cpbCount.ProgressWidth = 15;
            this.cpbCount.SecondaryFont = new System.Drawing.Font("宋体", 36F);
            this.cpbCount.Size = new System.Drawing.Size(104, 101);
            this.cpbCount.StartAngle = 270;
            this.cpbCount.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCount.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbCount.SubscriptText = "";
            this.cpbCount.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbCount.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbCount.SuperscriptText = "";
            this.cpbCount.TabIndex = 83;
            this.cpbCount.Text = "100";
            this.cpbCount.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cpbCount.Value = 100;
            this.cpbCount.Click += new System.EventHandler(this.cpbCount_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(220)))), ((int)(((byte)(100)))));
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnOK.BorderColor = System.Drawing.Color.White;
            this.btnOK.BorderInflate = new System.Drawing.Size(0, 0);
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.btnOK, CCWin.SkinControl.DecorationType.None);
            this.btnOK.DownBack = null;
            this.btnOK.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnOK.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.GlowColor = System.Drawing.Color.Gainsboro;
            this.btnOK.InnerBorderColor = System.Drawing.Color.White;
            this.btnOK.IsDrawGlass = false;
            this.btnOK.Location = new System.Drawing.Point(429, 35);
            this.btnOK.MouseBack = null;
            this.btnOK.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Palace = true;
            this.btnOK.Radius = 10;
            this.btnOK.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnOK.Size = new System.Drawing.Size(191, 88);
            this.btnOK.TabIndex = 79;
            this.btnOK.Text = "Start";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblSNC
            // 
            this.lblSNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSNC.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblSNC.AutoSize = true;
            this.lblSNC.BackColor = System.Drawing.Color.Transparent;
            this.lblSNC.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinAnimator1.SetDecoration(this.lblSNC, CCWin.SkinControl.DecorationType.None);
            this.lblSNC.Font = new System.Drawing.Font("Georgia", 26F, System.Drawing.FontStyle.Bold);
            this.lblSNC.ForeColor = System.Drawing.Color.Silver;
            this.lblSNC.Location = new System.Drawing.Point(687, 46);
            this.lblSNC.Name = "lblSNC";
            this.lblSNC.Size = new System.Drawing.Size(0, 41);
            this.lblSNC.TabIndex = 12;
            // 
            // skinAnimator1
            // 
            this.skinAnimator1.AnimationType = CCWin.SkinControl.AnimationType.Custom;
            this.skinAnimator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.skinAnimator1.DefaultAnimation = animation1;
            // 
            // FrmCH_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1145, 654);
            this.Controls.Add(this.MainSplit);
            this.skinAnimator1.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(896, 650);
            this.Name = "FrmCH_1";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "主框架窗口";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.skinPanel5.ResumeLayout(false);
            this.skinPanel6.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinPanel4.ResumeLayout(false);
            this.skinPanel4.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.cPnlHandle.ResumeLayout(false);
            this.cPnlHandle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerMain;
        private CCWin.SkinControl.SkinSplitContainer MainSplit;
        private CCWin.SkinControl.SkinPanel skinPanel5;
        private CCWin.SkinControl.SkinLabel lblSNC;
        private System.Windows.Forms.Timer timerDis;
        private CCWin.SkinControl.SkinPanel cPnlHandle;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinAnimator skinAnimator1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroComboBox cmbWorkOrder;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinPanel skinPanel6;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel lblSN;
        private CCWin.SkinControl.SkinPanel skinPanel4;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel lblType;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel lblPro;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinPictureBox picBox;
        private CCWin.SkinControl.SkinTextBox txbBoxID;
        private CircularProgressBar.CircularProgressBar cpbCountU;
        private CircularProgressBar.CircularProgressBar cpbCountP;
        private CircularProgressBar.CircularProgressBar cpbCount;
    }
}

