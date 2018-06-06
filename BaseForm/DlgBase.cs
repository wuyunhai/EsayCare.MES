using CCWin;
using CCWin.SkinControl;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace EsayCare.MES
{
    public partial class DlgBase : Skin_Color
    {
        private SkinPanel MainPanel;
        private SkinFlowLayoutPanel flowLayoutBottom;
        private SkinPanel skinPanel1;
         
        /// <summary>
        /// 插件位置
        /// </summary>
        public string PluginPath
        {
            get
            {
                string SelfPath = Assembly.GetExecutingAssembly().Location;
                SelfPath = SelfPath.Substring(0, SelfPath.LastIndexOf('\\'));
                return SelfPath;
            }
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgBase));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.flowLayoutBottom = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.MainPanel = new CCWin.SkinControl.SkinPanel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.flowLayoutBottom);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            resources.ApplyResources(this.skinPanel1, "skinPanel1");
            this.skinPanel1.DownBack = null;
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            // 
            // flowLayoutBottom
            // 
            this.flowLayoutBottom.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutBottom.ControlState = CCWin.SkinClass.ControlState.Normal;
            resources.ApplyResources(this.flowLayoutBottom, "flowLayoutBottom");
            this.flowLayoutBottom.DownBack = null;
            this.flowLayoutBottom.MouseBack = null;
            this.flowLayoutBottom.Name = "flowLayoutBottom";
            this.flowLayoutBottom.NormlBack = null;
            this.flowLayoutBottom.Radius = 4;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.DownBack = null;
            this.MainPanel.MouseBack = null;
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.NormlBack = null;
            this.MainPanel.Radius = 4;
            // 
            // DlgBase
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
            this.BackRectangle = new System.Drawing.Rectangle(2, 2, 2, 2);
            this.BorderColor = System.Drawing.Color.Gainsboro;
            this.BorderRectangle = new System.Drawing.Rectangle(1, 1, 1, 1);
            this.CaptionBackColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CaptionBackColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 9.2F);
            this.CaptionHeight = 28;
            this.CloseBoxSize = new System.Drawing.Size(45, 25);
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(2, 2);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.skinPanel1);
            this.EffectBack = System.Drawing.Color.WhiteSmoke;
            this.EffectWidth = 0;
            this.ICoOffset = new System.Drawing.Point(2, 0);
            this.IsShadowStraight = true;
            this.MdiBackColor = System.Drawing.Color.White;
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MdiImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Name = "DlgBase";
            this.Radius = 0;
            this.Shadow = true;
            this.ShadowColor = System.Drawing.Color.Gainsboro;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.skinPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public DlgBase()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }
        public Panel BaseMainPanel
        {
            get { return MainPanel; }
        }

        public FlowLayoutPanel BottomPane
        {
            get { return flowLayoutBottom; }
        }
        /// <summary>
        /// 构造对话框按钮
        /// </summary>
        /// <param name="Text">显示文本</param>
        /// <param name="Name">名称</param>
        /// <param name="TabIndex">Tab序号</param>
        /// <param name="eHandler">点击事件</param>
        /// <param name="btnResult">对话框响应</param>
        /// <returns></returns>
        public Button GenComandBtn(string Text, string Name, int TabIndex, EventHandler eHandler, DialogResult? btnResult = null)
        {
            SkinButton Btn = new SkinButton();
            Btn.IsDrawGlass = false;
            Btn.BaseColor = Color.WhiteSmoke;
            Btn.MouseBaseColor = Color.Gainsboro;
            Btn.DownBaseColor = Color.Gainsboro;
            Btn.BorderColor = Color.Gainsboro;
            Btn.ForeColor = Color.FromArgb(255,45,45,45);
            Btn.Text = Text;
            Btn.Size = new Size(100, 30);
            Btn.Height = 30;
            Btn.Width = (int)Btn.CreateGraphics().MeasureString(Text, Btn.Font).Width + 80;
            Btn.Name = Name;
            Btn.TabIndex = 0;
            Btn.TabIndex = TabIndex;
            Btn.UseVisualStyleBackColor = true;
            if (btnResult.HasValue)
            {
                Btn.DialogResult = btnResult.GetValueOrDefault(DialogResult.None);
            }
            Btn.Click += eHandler;
            return Btn;
        }
    }
}
