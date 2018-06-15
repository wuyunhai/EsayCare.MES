
namespace EsayCare.MES
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.staStripMain = new System.Windows.Forms.StatusStrip();
            this.staStripShowOutWnd = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripX1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripNote = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripTest2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripX2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.CenterImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.cpnl = new CCWin.SkinControl.SkinCaptionPanel();
            this.skinPushPanel1 = new CCWin.SkinControl.SkinPushPanel();
            this.pushPanelItem1 = new CCWin.SkinControl.PushPanelItem();
            this.lstMenu = new CCWin.SkinControl.SkinListBox();
            this.splitContent = new CCWin.SkinControl.SkinSplitContainer();
            this.tabControl = new CCWin.SkinControl.SkinTabControl();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.timerDis = new System.Windows.Forms.Timer(this.components);
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.logoPic = new CCWin.SkinControl.SkinPictureBox();
            this.lblDeviceName = new CCWin.SkinControl.SkinLabel();
            this.lblDeviceID = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.lblInfo = new CCWin.SkinControl.SkinLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.busyCon = new CircularProgressBar.CircularProgressBar();
            this.staStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.cpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel1)).BeginInit();
            this.skinPushPanel1.SuspendLayout();
            this.pushPanelItem1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContent)).BeginInit();
            this.splitContent.Panel1.SuspendLayout();
            this.splitContent.Panel2.SuspendLayout();
            this.splitContent.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // staStripMain
            // 
            this.staStripMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.staStripMain.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.staStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staStripShowOutWnd,
            this.staStripX1,
            this.staStripNote,
            this.staStripTest2,
            this.staStripX2,
            this.lblLoginUser,
            this.staStripTime,
            this.toolStripStatusLabel1,
            this.staStripVersion,
            this.CenterImage});
            this.staStripMain.Location = new System.Drawing.Point(6, 622);
            this.staStripMain.Name = "staStripMain";
            this.staStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.staStripMain.Size = new System.Drawing.Size(886, 26);
            this.staStripMain.TabIndex = 1;
            // 
            // staStripShowOutWnd
            // 
            this.staStripShowOutWnd.ForeColor = System.Drawing.Color.Black;
            this.staStripShowOutWnd.Name = "staStripShowOutWnd";
            this.staStripShowOutWnd.Size = new System.Drawing.Size(83, 21);
            this.staStripShowOutWnd.Text = " ↑ [条码-日志]";
            this.staStripShowOutWnd.Click += new System.EventHandler(this.staStripShowOutWnd_Click);
            // 
            // staStripX1
            // 
            this.staStripX1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.staStripX1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.staStripX1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.staStripX1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.staStripX1.Name = "staStripX1";
            this.staStripX1.Size = new System.Drawing.Size(16, 21);
            this.staStripX1.Text = " ";
            // 
            // staStripNote
            // 
            this.staStripNote.AutoSize = false;
            this.staStripNote.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.staStripNote.ForeColor = System.Drawing.Color.Black;
            this.staStripNote.Name = "staStripNote";
            this.staStripNote.Size = new System.Drawing.Size(550, 21);
            this.staStripNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // staStripTest2
            // 
            this.staStripTest2.ForeColor = System.Drawing.Color.Black;
            this.staStripTest2.Name = "staStripTest2";
            this.staStripTest2.Size = new System.Drawing.Size(17, 21);
            this.staStripTest2.Text = "...";
            this.staStripTest2.Click += new System.EventHandler(this.staStripTest2_Click);
            // 
            // staStripX2
            // 
            this.staStripX2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.staStripX2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.staStripX2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.staStripX2.Enabled = false;
            this.staStripX2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.staStripX2.Name = "staStripX2";
            this.staStripX2.Size = new System.Drawing.Size(16, 21);
            this.staStripX2.Text = " ";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblLoginUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(45, 21);
            this.lblLoginUser.Text = "Admin";
            // 
            // staStripTime
            // 
            this.staStripTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.staStripTime.Name = "staStripTime";
            this.staStripTime.Size = new System.Drawing.Size(86, 21);
            this.staStripTime.Spring = true;
            this.staStripTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 21);
            this.toolStripStatusLabel1.Text = " ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // staStripVersion
            // 
            this.staStripVersion.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.staStripVersion.ForeColor = System.Drawing.Color.Black;
            this.staStripVersion.Name = "staStripVersion";
            this.staStripVersion.Size = new System.Drawing.Size(44, 21);
            this.staStripVersion.Text = "版本：";
            // 
            // CenterImage
            // 
            this.CenterImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterImage.Name = "CenterImage";
            this.CenterImage.Size = new System.Drawing.Size(0, 21);
            this.CenterImage.Text = "toolStripStatusLabel2";
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // MainSplit
            // 
            this.MainSplit.BackColor = System.Drawing.Color.White;
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainSplit.Location = new System.Drawing.Point(6, 105);
            this.MainSplit.Margin = new System.Windows.Forms.Padding(0);
            this.MainSplit.Name = "MainSplit";
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.Controls.Add(this.cpnl);
            this.MainSplit.Panel1MinSize = 205;
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.BackColor = System.Drawing.Color.White;
            this.MainSplit.Panel2.Controls.Add(this.splitContent);
            this.MainSplit.Panel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.MainSplit.Size = new System.Drawing.Size(886, 517);
            this.MainSplit.SplitterDistance = 205;
            this.MainSplit.SplitterWidth = 1;
            this.MainSplit.TabIndex = 5;
            this.MainSplit.TabStop = false;
            // 
            // cpnl
            // 
            this.cpnl.CaptionFont = new System.Drawing.Font("微软雅黑", 9F);
            this.cpnl.CaptionHeight = 30;
            this.cpnl.Controls.Add(this.skinPushPanel1);
            this.cpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpnl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cpnl.Location = new System.Drawing.Point(0, 0);
            this.cpnl.Name = "cpnl";
            this.cpnl.Radius = 2;
            this.cpnl.RoundStyle = CCWin.SkinClass.RoundStyle.Top;
            this.cpnl.Size = new System.Drawing.Size(205, 517);
            this.cpnl.TabIndex = 12;
            this.cpnl.Text = " 菜单管理";
            // 
            // skinPushPanel1
            // 
            this.skinPushPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPushPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinPushPanel1.ImageStyle = CCWin.SkinControl.CaptionImageStyle.Image;
            this.skinPushPanel1.Items.AddRange(new CCWin.SkinControl.PushPanelItem[] {
            this.pushPanelItem1});
            this.skinPushPanel1.Location = new System.Drawing.Point(0, 30);
            this.skinPushPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinPushPanel1.Name = "skinPushPanel1";
            this.skinPushPanel1.Radius = 2;
            this.skinPushPanel1.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.skinPushPanel1.Size = new System.Drawing.Size(205, 487);
            this.skinPushPanel1.TabIndex = 9;
            // 
            // pushPanelItem1
            // 
            this.pushPanelItem1.Border = System.Drawing.Color.WhiteSmoke;
            this.pushPanelItem1.CaptionBackHover = System.Drawing.Color.Silver;
            this.pushPanelItem1.CaptionBackNormal = System.Drawing.Color.LightGray;
            this.pushPanelItem1.CaptionBackPressed = System.Drawing.Color.DarkGray;
            this.pushPanelItem1.CaptionFont = new System.Drawing.Font("微软雅黑", 9F);
            this.pushPanelItem1.CaptionFore = System.Drawing.Color.Black;
            this.pushPanelItem1.Controls.Add(this.lstMenu);
            this.pushPanelItem1.Name = "pushPanelItem1";
            this.pushPanelItem1.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.pushPanelItem1.Text = "彩盒线";
            // 
            // lstMenu
            // 
            this.lstMenu.Back = null;
            this.lstMenu.BorderColor = System.Drawing.Color.Transparent;
            this.lstMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstMenu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.ItemHeight = 28;
            this.lstMenu.ItemHoverGlassVisble = true;
            this.lstMenu.Items.AddRange(new CCWin.SkinControl.SkinListBoxItem[] {
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lstMenu.Items"))),
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lstMenu.Items1"))),
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lstMenu.Items2")))});
            this.lstMenu.Location = new System.Drawing.Point(1, 24);
            this.lstMenu.MouseColor = System.Drawing.Color.Gainsboro;
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.RowBackColor1 = System.Drawing.Color.WhiteSmoke;
            this.lstMenu.RowBackColor2 = System.Drawing.Color.White;
            this.lstMenu.SelectedColor = System.Drawing.Color.Gold;
            this.lstMenu.Size = new System.Drawing.Size(201, 460);
            this.lstMenu.TabIndex = 1;
            this.lstMenu.SelectedIndexChanged += new System.EventHandler(this.skinListBox_Click);
            // 
            // splitContent
            // 
            this.splitContent.CollapsePanel = CCWin.SkinControl.CollapsePanel.None;
            this.splitContent.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContent.LineBack = System.Drawing.Color.White;
            this.splitContent.LineBack2 = System.Drawing.Color.White;
            this.splitContent.Location = new System.Drawing.Point(0, 0);
            this.splitContent.Name = "splitContent";
            this.splitContent.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContent.Panel1
            // 
            this.splitContent.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContent.Panel2
            // 
            this.splitContent.Panel2.Controls.Add(this.rtbLog);
            this.splitContent.Panel2Collapsed = true;
            this.splitContent.Panel2MinSize = 100;
            this.splitContent.Size = new System.Drawing.Size(680, 517);
            this.splitContent.SplitterDistance = 25;
            this.splitContent.SplitterWidth = 1;
            this.splitContent.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabControl.ArrowBaseColor = System.Drawing.Color.Silver;
            this.tabControl.ArrowBorderColor = System.Drawing.Color.Silver;
            this.tabControl.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabControl.CloseRect = new System.Drawing.Rectangle(0, 0, 18, 18);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tabControl.HeadBack = null;
            this.tabControl.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabControl.ItemSize = new System.Drawing.Size(180, 30);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControl.PageArrowDown")));
            this.tabControl.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabControl.PageArrowHover")));
            this.tabControl.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabControl.PageCloseHover")));
            this.tabControl.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabControl.PageCloseNormal")));
            this.tabControl.PageDown = ((System.Drawing.Image)(resources.GetObject("tabControl.PageDown")));
            this.tabControl.PageHover = ((System.Drawing.Image)(resources.GetObject("tabControl.PageHover")));
            this.tabControl.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabControl.PageNorml = null;
            this.tabControl.PageNormlTxtColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabControl.Size = new System.Drawing.Size(680, 517);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 21;
            this.tabControl.TabePageClosed += new CCWin.SkinControl.SkinTabControl.ClosedTabePageHandler(this.tabControl_TabePageClosed);
            this.tabControl.TabePageClosing += new CCWin.SkinControl.SkinTabControl.ClosingTabePageHandler(this.tabControl_TabePageClosing);
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rtbLog.ForeColor = System.Drawing.Color.Yellow;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(150, 46);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            // 
            // timerDis
            // 
            this.timerDis.Enabled = true;
            this.timerDis.Interval = 700;
            this.timerDis.Tick += new System.EventHandler(this.timerDis_Tick);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.White;
            this.skinPanel1.BackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.skinPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.skinPanel1.Controls.Add(this.metroTextBox2);
            this.skinPanel1.Controls.Add(this.logoPic);
            this.skinPanel1.Controls.Add(this.lblDeviceName);
            this.skinPanel1.Controls.Add(this.lblDeviceID);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.metroTextBox1);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.lblInfo);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(6, 30);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Radius = 4;
            this.skinPanel1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel1.Size = new System.Drawing.Size(886, 75);
            this.skinPanel1.TabIndex = 6;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroTextBox2.Lines = new string[] {
        "metroTextBox2"};
            this.metroTextBox2.Location = new System.Drawing.Point(205, 0);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ReadOnly = true;
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(1, 75);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.StyleManager = null;
            this.metroTextBox2.TabIndex = 84;
            this.metroTextBox2.Text = "metroTextBox2";
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.UseSelectable = true;
            // 
            // logoPic
            // 
            this.logoPic.BackColor = System.Drawing.Color.Transparent;
            this.logoPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPic.Image = ((System.Drawing.Image)(resources.GetObject("logoPic.Image")));
            this.logoPic.Location = new System.Drawing.Point(0, 0);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(205, 75);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPic.TabIndex = 83;
            this.logoPic.TabStop = false;
            this.logoPic.Click += new System.EventHandler(this.logoPic_Click);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeviceName.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblDeviceName.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceName.BorderColor = System.Drawing.Color.Gainsboro;
            this.lblDeviceName.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDeviceName.Location = new System.Drawing.Point(699, 39);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(178, 23);
            this.lblDeviceName.TabIndex = 82;
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeviceID.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblDeviceID.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceID.BorderColor = System.Drawing.Color.Gainsboro;
            this.lblDeviceID.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeviceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDeviceID.Location = new System.Drawing.Point(699, 8);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(176, 23);
            this.lblDeviceID.TabIndex = 81;
            // 
            // skinLabel5
            // 
            this.skinLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.skinLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinLabel5.Location = new System.Drawing.Point(625, 39);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(68, 19);
            this.skinLabel5.TabIndex = 80;
            this.skinLabel5.Text = "设备名称 :";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(613, 5);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(1, 70);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.StyleManager = null;
            this.metroTextBox1.TabIndex = 78;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.UseSelectable = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinLabel4.Location = new System.Drawing.Point(625, 8);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(58, 19);
            this.skinLabel4.TabIndex = 74;
            this.skinLabel4.Text = "设备 IP :";
            // 
            // lblInfo
            // 
            this.lblInfo.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.BorderColor = System.Drawing.Color.White;
            this.lblInfo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.lblInfo.Location = new System.Drawing.Point(211, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(64, 26);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Init....";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "001-server.png");
            this.imageList1.Images.SetKeyName(1, "modify.png");
            this.imageList1.Images.SetKeyName(2, "服务器.png");
            // 
            // busyCon
            // 
            this.busyCon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.busyCon.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.busyCon.AnimationSpeed = 500;
            this.busyCon.BackColor = System.Drawing.Color.Transparent;
            this.busyCon.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold);
            this.busyCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.busyCon.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.busyCon.InnerMargin = 0;
            this.busyCon.InnerWidth = 0;
            this.busyCon.Location = new System.Drawing.Point(492, 374);
            this.busyCon.MarqueeAnimationSpeed = 2000;
            this.busyCon.Name = "busyCon";
            this.busyCon.OuterColor = System.Drawing.Color.DarkGray;
            this.busyCon.OuterMargin = -11;
            this.busyCon.OuterWidth = 8;
            this.busyCon.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.busyCon.ProgressWidth = 14;
            this.busyCon.SecondaryFont = new System.Drawing.Font("宋体", 9F);
            this.busyCon.Size = new System.Drawing.Size(165, 160);
            this.busyCon.StartAngle = 270;
            this.busyCon.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.busyCon.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.busyCon.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.busyCon.SubscriptText = "";
            this.busyCon.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.busyCon.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.busyCon.SuperscriptText = "";
            this.busyCon.TabIndex = 3;
            this.busyCon.Text = "Please wait ...";
            this.busyCon.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.busyCon.Value = 65;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9F);
            this.ClientSize = new System.Drawing.Size(898, 654);
            this.Controls.Add(this.MainSplit);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.staStripMain);
            this.Controls.Add(this.busyCon);
            this.EffectWidth = 2;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(2, 0);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(896, 650);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.Radius = 2;
            this.Shadow = false;
            this.ShadowRectangle = new System.Drawing.Rectangle(2, 2, 2, 2);
            this.ShadowWidth = 1;
            this.ShowBorder = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "主框架窗口";
            this.TitleCenter = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.staStripMain.ResumeLayout(false);
            this.staStripMain.PerformLayout();
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.cpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel1)).EndInit();
            this.skinPushPanel1.ResumeLayout(false);
            this.pushPanelItem1.ResumeLayout(false);
            this.splitContent.Panel1.ResumeLayout(false);
            this.splitContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContent)).EndInit();
            this.splitContent.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip staStripMain;
        private System.Windows.Forms.ToolStripStatusLabel staStripNote;
        private System.Windows.Forms.ToolStripStatusLabel staStripX1;
        private System.Windows.Forms.ToolStripStatusLabel staStripShowOutWnd;
        private System.Windows.Forms.ToolStripStatusLabel staStripX2;
        private System.Windows.Forms.ToolStripStatusLabel staStripTest2;
        private System.Windows.Forms.ToolStripStatusLabel staStripTime;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ToolStripStatusLabel staStripVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginUser;
        private System.Windows.Forms.ToolStripStatusLabel CenterImage;
        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.Timer timerDis;
        private CCWin.SkinControl.SkinSplitContainer splitContent;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel lblDeviceName;
        private CCWin.SkinControl.SkinLabel lblDeviceID;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel lblInfo;
        private CCWin.SkinControl.SkinCaptionPanel cpnl;
        private CCWin.SkinControl.SkinPushPanel skinPushPanel1;
        private CCWin.SkinControl.PushPanelItem pushPanelItem1;
        private System.Windows.Forms.ImageList imageList1;
        private CCWin.SkinControl.SkinPictureBox logoPic;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private CCWin.SkinControl.SkinListBox lstMenu;
        private System.Windows.Forms.RichTextBox rtbLog;
        private CCWin.SkinControl.SkinTabControl tabControl;
        private CircularProgressBar.CircularProgressBar busyCon;
    }
}

