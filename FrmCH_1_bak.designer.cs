
namespace EsayCare.MES
{
    partial class FrmCH_1_bak
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCH_1));
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.MainSplit = new CCWin.SkinControl.SkinSplitContainer();
            this.skinPanel5 = new CCWin.SkinControl.SkinPanel();
            this.cPnlHandle = new CCWin.SkinControl.SkinCaptionPanel();
            this.cmbWorkOrder = new CCWin.SkinControl.SkinComboBox();
            this.txbBoxID = new CCWin.SkinControl.SkinTextBox();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.lblSNC = new CCWin.SkinControl.SkinLabel();
            this.lbl2 = new CCWin.SkinControl.SkinLabel();
            this.lbl3 = new CCWin.SkinControl.SkinLabel();
            this.cPnlWorkOrder = new CCWin.SkinControl.SkinCaptionPanel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.dgvList = new CCWin.SkinControl.SkinDataGridView();
            this.CH_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CH_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CH_Attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCountU = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.lblCount = new CCWin.SkinControl.SkinLabel();
            this.lblCountP = new CCWin.SkinControl.SkinLabel();
            this.cPnlPicView = new CCWin.SkinControl.SkinCaptionPanel();
            this.picBox = new CCWin.SkinControl.SkinPictureBox();
            this.timerDis = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.skinPanel5.SuspendLayout();
            this.cPnlHandle.SuspendLayout();
            this.cPnlWorkOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.cPnlPicView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplit
            // 
            this.MainSplit.BackColor = System.Drawing.Color.White;
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplit.IsSplitterFixed = true;
            this.MainSplit.Location = new System.Drawing.Point(2, 0);
            this.MainSplit.Margin = new System.Windows.Forms.Padding(0);
            this.MainSplit.Name = "MainSplit";
            this.MainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.MainSplit.Panel1Collapsed = true;
            this.MainSplit.Panel1MinSize = 1;
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.BackColor = System.Drawing.Color.White;
            this.MainSplit.Panel2.Controls.Add(this.skinPanel5);
            this.MainSplit.Panel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.MainSplit.Size = new System.Drawing.Size(894, 652);
            this.MainSplit.SplitterDistance = 25;
            this.MainSplit.SplitterWidth = 1;
            this.MainSplit.TabIndex = 5;
            this.MainSplit.TabStop = false;
            // 
            // skinPanel5
            // 
            this.skinPanel5.BackColor = System.Drawing.Color.White;
            this.skinPanel5.Controls.Add(this.cPnlHandle);
            this.skinPanel5.Controls.Add(this.cPnlWorkOrder);
            this.skinPanel5.Controls.Add(this.cPnlPicView);
            this.skinPanel5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel5.DownBack = null;
            this.skinPanel5.Location = new System.Drawing.Point(0, 0);
            this.skinPanel5.MouseBack = null;
            this.skinPanel5.Name = "skinPanel5";
            this.skinPanel5.NormlBack = null;
            this.skinPanel5.Size = new System.Drawing.Size(894, 652);
            this.skinPanel5.TabIndex = 3;
            // 
            // cPnlHandle
            // 
            this.cPnlHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cPnlHandle.CaptionFont = new System.Drawing.Font("微软雅黑", 9F);
            this.cPnlHandle.CaptionHeight = 30;
            this.cPnlHandle.Controls.Add(this.cmbWorkOrder);
            this.cPnlHandle.Controls.Add(this.txbBoxID);
            this.cPnlHandle.Controls.Add(this.btnCancel);
            this.cPnlHandle.Controls.Add(this.btnOK);
            this.cPnlHandle.Controls.Add(this.skinLabel5);
            this.cPnlHandle.Controls.Add(this.skinLabel4);
            this.cPnlHandle.Controls.Add(this.lblSNC);
            this.cPnlHandle.Controls.Add(this.lbl2);
            this.cPnlHandle.Controls.Add(this.lbl3);
            this.cPnlHandle.ForeColor = System.Drawing.Color.DarkGray;
            this.cPnlHandle.Location = new System.Drawing.Point(3, 3);
            this.cPnlHandle.Name = "cPnlHandle";
            this.cPnlHandle.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.cPnlHandle.ShowBorder = true;
            this.cPnlHandle.Size = new System.Drawing.Size(888, 114);
            this.cPnlHandle.TabIndex = 76;
            this.cPnlHandle.Text = "彩盒上料";
            // 
            // cmbWorkOrder
            // 
            this.cmbWorkOrder.ArrowColor = System.Drawing.Color.Gray;
            this.cmbWorkOrder.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbWorkOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbWorkOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWorkOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbWorkOrder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.cmbWorkOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbWorkOrder.FormattingEnabled = true;
            this.cmbWorkOrder.Location = new System.Drawing.Point(81, 40);
            this.cmbWorkOrder.Name = "cmbWorkOrder";
            this.cmbWorkOrder.Size = new System.Drawing.Size(315, 24);
            this.cmbWorkOrder.TabIndex = 82;
            this.cmbWorkOrder.WaterText = "";
            this.cmbWorkOrder.DropDown += new System.EventHandler(this.cmbWO_DropDown);
            this.cmbWorkOrder.DropDownClosed += new System.EventHandler(this.cmbWO_DropDownClosed);
            // 
            // txbBoxID
            // 
            this.txbBoxID.BackColor = System.Drawing.Color.Transparent;
            this.txbBoxID.DownBack = null;
            this.txbBoxID.Icon = null;
            this.txbBoxID.IconIsButton = false;
            this.txbBoxID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txbBoxID.IsPasswordChat = '\0';
            this.txbBoxID.IsSystemPasswordChar = false;
            this.txbBoxID.Lines = new string[] {
        "ID19890929"};
            this.txbBoxID.Location = new System.Drawing.Point(81, 72);
            this.txbBoxID.Margin = new System.Windows.Forms.Padding(0);
            this.txbBoxID.MaxLength = 32767;
            this.txbBoxID.MinimumSize = new System.Drawing.Size(28, 28);
            this.txbBoxID.MouseBack = null;
            this.txbBoxID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txbBoxID.Multiline = false;
            this.txbBoxID.Name = "txbBoxID";
            this.txbBoxID.NormlBack = null;
            this.txbBoxID.Padding = new System.Windows.Forms.Padding(5);
            this.txbBoxID.ReadOnly = false;
            this.txbBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBoxID.Size = new System.Drawing.Size(315, 28);
            // 
            // 
            // 
            this.txbBoxID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBoxID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbBoxID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.txbBoxID.SkinTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbBoxID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txbBoxID.SkinTxt.Name = "BaseText";
            this.txbBoxID.SkinTxt.Size = new System.Drawing.Size(305, 16);
            this.txbBoxID.SkinTxt.TabIndex = 0;
            this.txbBoxID.SkinTxt.Text = "ID19890929";
            this.txbBoxID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txbBoxID.SkinTxt.WaterText = "";
            this.txbBoxID.TabIndex = 81;
            this.txbBoxID.Text = "ID19890929";
            this.txbBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbBoxID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txbBoxID.WaterText = "";
            this.txbBoxID.WordWrap = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Red;
            this.btnCancel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.IsDrawBorder = false;
            this.btnCancel.Location = new System.Drawing.Point(532, 40);
            this.btnCancel.MouseBack = null;
            this.btnCancel.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Radius = 4;
            this.btnCancel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnCancel.Size = new System.Drawing.Size(121, 60);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "暂 停";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.DownBaseColor = System.Drawing.Color.Green;
            this.btnOK.Enabled = false;
            this.btnOK.FadeGlow = false;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.GlowColor = System.Drawing.Color.Green;
            this.btnOK.IsDrawBorder = false;
            this.btnOK.Location = new System.Drawing.Point(405, 40);
            this.btnOK.MouseBack = null;
            this.btnOK.MouseBaseColor = System.Drawing.Color.Green;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Radius = 4;
            this.btnOK.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnOK.Size = new System.Drawing.Size(121, 60);
            this.btnOK.TabIndex = 79;
            this.btnOK.Text = "开始生产";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // skinLabel5
            // 
            this.skinLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel5.ForeColor = System.Drawing.Color.Gray;
            this.skinLabel5.Location = new System.Drawing.Point(670, 5);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(11, 17);
            this.skinLabel5.TabIndex = 78;
            this.skinLabel5.Text = "|";
            // 
            // skinLabel4
            // 
            this.skinLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.skinLabel4.Location = new System.Drawing.Point(687, 7);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(97, 17);
            this.skinLabel4.TabIndex = 77;
            this.skinLabel4.Text = "产品SN校验结果";
            // 
            // lblSNC
            // 
            this.lblSNC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSNC.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblSNC.AutoSize = true;
            this.lblSNC.BackColor = System.Drawing.Color.Transparent;
            this.lblSNC.BorderColor = System.Drawing.Color.Gainsboro;
            this.lblSNC.Font = new System.Drawing.Font("Georgia", 26F, System.Drawing.FontStyle.Bold);
            this.lblSNC.ForeColor = System.Drawing.Color.Silver;
            this.lblSNC.Location = new System.Drawing.Point(692, 46);
            this.lblSNC.Name = "lblSNC";
            this.lblSNC.Size = new System.Drawing.Size(0, 41);
            this.lblSNC.TabIndex = 12;
            // 
            // lbl2
            // 
            this.lbl2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.BorderColor = System.Drawing.Color.White;
            this.lbl2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl2.Location = new System.Drawing.Point(4, 43);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(80, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "选择制令单：";
            // 
            // lbl3
            // 
            this.lbl3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.BorderColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl3.Location = new System.Drawing.Point(4, 79);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(81, 17);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "彩盒ID扫描：";
            // 
            // cPnlWorkOrder
            // 
            this.cPnlWorkOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cPnlWorkOrder.CaptionFont = new System.Drawing.Font("微软雅黑", 9F);
            this.cPnlWorkOrder.CaptionHeight = 30;
            this.cPnlWorkOrder.Controls.Add(this.skinLabel11);
            this.cPnlWorkOrder.Controls.Add(this.dgvList);
            this.cPnlWorkOrder.Controls.Add(this.lblCountU);
            this.cPnlWorkOrder.Controls.Add(this.skinLabel7);
            this.cPnlWorkOrder.Controls.Add(this.skinLabel9);
            this.cPnlWorkOrder.Controls.Add(this.lblCount);
            this.cPnlWorkOrder.Controls.Add(this.lblCountP);
            this.cPnlWorkOrder.ForeColor = System.Drawing.Color.DarkGray;
            this.cPnlWorkOrder.Location = new System.Drawing.Point(3, 120);
            this.cPnlWorkOrder.Name = "cPnlWorkOrder";
            this.cPnlWorkOrder.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.cPnlWorkOrder.ShowBorder = true;
            this.cPnlWorkOrder.Size = new System.Drawing.Size(888, 108);
            this.cPnlWorkOrder.TabIndex = 75;
            this.cPnlWorkOrder.Text = "彩盒工单";
            // 
            // skinLabel11
            // 
            this.skinLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel11.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skinLabel11.Location = new System.Drawing.Point(802, 7);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(56, 17);
            this.skinLabel11.TabIndex = 26;
            this.skinLabel11.Text = "未生产数";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AlternatingCellBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvList.ColumnFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.dgvList.ColumnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeight = 30;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CH_Order,
            this.CH_type,
            this.CH_Attribute,
            this.Description});
            this.dgvList.ColumnSelectBackColor = System.Drawing.Color.White;
            this.dgvList.ColumnSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.dgvList.GridColor = System.Drawing.Color.LightGray;
            this.dgvList.HeadFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.dgvList.HeadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvList.HeadSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvList.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvList.LineNumberForeColor = System.Drawing.Color.Gray;
            this.dgvList.Location = new System.Drawing.Point(1, 30);
            this.dgvList.MouseCellBackColor = System.Drawing.Color.White;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 25;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowTemplate.Height = 48;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(886, 77);
            this.dgvList.SkinGridColor = System.Drawing.Color.LightGray;
            this.dgvList.TabIndex = 67;
            this.dgvList.TitleBack = null;
            this.dgvList.TitleBackColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.dgvList.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // CH_Order
            // 
            this.CH_Order.DataPropertyName = "CH_Order";
            this.CH_Order.HeaderText = "彩盒SN";
            this.CH_Order.Name = "CH_Order";
            this.CH_Order.ReadOnly = true;
            // 
            // CH_type
            // 
            this.CH_type.DataPropertyName = "CH_type";
            this.CH_type.HeaderText = "类型";
            this.CH_type.Name = "CH_type";
            this.CH_type.ReadOnly = true;
            // 
            // CH_Attribute
            // 
            this.CH_Attribute.DataPropertyName = "CH_Attribute";
            this.CH_Attribute.HeaderText = "属性";
            this.CH_Attribute.Name = "CH_Attribute";
            this.CH_Attribute.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "描述";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // lblCountU
            // 
            this.lblCountU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountU.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblCountU.AutoSize = true;
            this.lblCountU.BackColor = System.Drawing.Color.Transparent;
            this.lblCountU.BorderColor = System.Drawing.Color.Gainsboro;
            this.lblCountU.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCountU.Location = new System.Drawing.Point(860, 5);
            this.lblCountU.Name = "lblCountU";
            this.lblCountU.Size = new System.Drawing.Size(18, 19);
            this.lblCountU.TabIndex = 25;
            this.lblCountU.Text = "0";
            // 
            // skinLabel7
            // 
            this.skinLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel7.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.skinLabel7.Location = new System.Drawing.Point(587, 7);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(56, 17);
            this.skinLabel7.TabIndex = 22;
            this.skinLabel7.Text = "工单总数";
            // 
            // skinLabel9
            // 
            this.skinLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel9.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.skinLabel9.Location = new System.Drawing.Point(699, 7);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(56, 17);
            this.skinLabel9.TabIndex = 24;
            this.skinLabel9.Text = "已生产数";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.BorderColor = System.Drawing.Color.Gainsboro;
            this.lblCount.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCount.Location = new System.Drawing.Point(646, 5);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 19);
            this.lblCount.TabIndex = 21;
            this.lblCount.Text = "0";
            // 
            // lblCountP
            // 
            this.lblCountP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountP.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblCountP.AutoSize = true;
            this.lblCountP.BackColor = System.Drawing.Color.Transparent;
            this.lblCountP.BorderColor = System.Drawing.Color.Gainsboro;
            this.lblCountP.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lblCountP.Location = new System.Drawing.Point(759, 5);
            this.lblCountP.Name = "lblCountP";
            this.lblCountP.Size = new System.Drawing.Size(18, 19);
            this.lblCountP.TabIndex = 23;
            this.lblCountP.Text = "0";
            // 
            // cPnlPicView
            // 
            this.cPnlPicView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cPnlPicView.CaptionFont = new System.Drawing.Font("微软雅黑", 9F);
            this.cPnlPicView.CaptionHeight = 30;
            this.cPnlPicView.Controls.Add(this.picBox);
            this.cPnlPicView.ForeColor = System.Drawing.Color.DarkGray;
            this.cPnlPicView.Location = new System.Drawing.Point(3, 227);
            this.cPnlPicView.Name = "cPnlPicView";
            this.cPnlPicView.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.cPnlPicView.ShowBorder = true;
            this.cPnlPicView.Size = new System.Drawing.Size(888, 402);
            this.cPnlPicView.TabIndex = 74;
            this.cPnlPicView.Text = "彩盒封面";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(1, 30);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(886, 371);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // FrmCH_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(898, 654);
            this.Controls.Add(this.MainSplit);
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
            this.cPnlHandle.ResumeLayout(false);
            this.cPnlHandle.PerformLayout();
            this.cPnlWorkOrder.ResumeLayout(false);
            this.cPnlWorkOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.cPnlPicView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerMain;
        private CCWin.SkinControl.SkinSplitContainer MainSplit;
        private CCWin.SkinControl.SkinPanel skinPanel5;
        private CCWin.SkinControl.SkinLabel lbl3;
        private CCWin.SkinControl.SkinLabel lbl2;
        private CCWin.SkinControl.SkinLabel lblSNC;
        private System.Windows.Forms.Timer timerDis;
        private CCWin.SkinControl.SkinCaptionPanel cPnlPicView;
        private CCWin.SkinControl.SkinPictureBox picBox;
        private CCWin.SkinControl.SkinCaptionPanel cPnlWorkOrder;
        private CCWin.SkinControl.SkinDataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn CH_Attribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel lblCountU;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel lblCountP;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel lblCount;
        private CCWin.SkinControl.SkinCaptionPanel cPnlHandle;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinTextBox txbBoxID;
        private CCWin.SkinControl.SkinComboBox cmbWorkOrder;
    }
}

