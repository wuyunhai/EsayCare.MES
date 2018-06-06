using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EsayCare.MES
{
    public partial class FormRoot : Form
    {
        #region ** 系统预留方法声明 **
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        #endregion
        private ContentAlignment _titleAlign;
        /// <summary>
        /// 标题栏文本对齐方式
        /// </summary>
        public ContentAlignment TitleTextAlign
        {
            get { return _titleAlign; }
            set
            {
                _titleAlign = value;
                TitlePanel.Refresh();
            }
        }
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
        /// <summary>
        /// 标题栏图标
        /// </summary>
        public new Image Icon { get; set; }
        /// <summary>
        /// 显示最小化按钮
        /// </summary>
        public new bool MinimizeBox
        {
            get { return MinButton.Visible; }
            set { MinButton.Visible = value; }
        }
        /// <summary>
        /// 显示最大化按钮
        /// </summary>
        public new bool MaximizeBox
        {
            get { return MaxButton.Visible; }
            set { MaxButton.Visible = value;}
        }

        public Panel ClientRootPanel
        {
            get { return RootMainPanel; }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public FormRoot()
        {
            InitializeComponent();
            _titleAlign = ContentAlignment.TopLeft;
        }

        /// <summary>
        /// 对话框载入
        /// </summary>
        private void DlgRoot_Load(object sender, EventArgs e)
        {
            CloseButton.Visible = ControlBox;
        }

        /// <summary>
        /// 标题栏拖动窗口
        /// </summary>
        private void Titlepanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        /// <summary>
        /// 重绘标题栏
        /// </summary>
        private void DlgBase_TextChanged(object sender, EventArgs e)
        {
            //重绘标题栏
            TitlePanel.Refresh();
        }

        /// <summary>
        /// 画边框
        /// </summary>
        private void RootPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = RootPanel.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
            e.Graphics.DrawRectangle(new Pen(Color.Gainsboro, 1), rect);
        }
        /// <summary>
        /// 单击控制按钮事件
        /// </summary>
        private void ControlButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "CloseButton":
                    this.DialogResult = DialogResult.None;
                    this.Close();
                    break;
                case "MinButton":
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case "MaxButton":
                    this.WindowState = (this.WindowState == FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;
                    break;
            }
        }
        /// <summary>
        /// 绘制标题栏
        /// </summary>
        private void TitlePanel_Paint(object sender, PaintEventArgs e)
        {
            PointF titleP = new PointF(5, 2);
            var g = e.Graphics;
            string path = PluginPath + "\\Res\\StripMain.png";
            if (!string.IsNullOrEmpty(PluginPath) && File.Exists(path))
            {
                //Image backimg = Image.FromFile(path);
                //backimg = backimg.GetThumbnailImage(TitlePanel.Width, TitlePanel.Height, null, IntPtr.Zero);
                //g.DrawImage(backimg, 0, 0);
            }
            if (ShowIcon)
            {
                if (Icon == null)
                {
                    path = PluginPath + "\\Res\\metasystem-logo.png";
                    if (File.Exists(path))
                    {
                        Icon = Image.FromFile(path);
                    }
                }
                if (Icon != null)
                {
                    g.DrawImage(Icon, 5, 0);
                    titleP.X += Icon.Width + 5;
                }
            }
            SizeF textsize = g.MeasureString(Text, Font);
            switch (TitleTextAlign)
            {
                case ContentAlignment.BottomCenter:
                    titleP.X = (TitlePanel.Width - titleP.X - textsize.Width) / 2;
                    titleP.Y = TitlePanel.Height - textsize.Height - 2;
                    break;
                case ContentAlignment.TopCenter:
                    titleP.X = (TitlePanel.Width - titleP.X - textsize.Width) / 2;
                    break;
                case ContentAlignment.TopRight:
                    titleP.X = TitlePanel.Width - textsize.Width - CloseButton.Width - 5;
                    break;
                case ContentAlignment.TopLeft:
                    break;
                case ContentAlignment.BottomLeft:
                    titleP.Y = TitlePanel.Height - textsize.Height - 2;
                    break;
                case ContentAlignment.BottomRight:
                    titleP.X = TitlePanel.Width - textsize.Width - CloseButton.Width - 5;
                    titleP.Y = TitlePanel.Height - textsize.Height - 2;
                    break;
                case ContentAlignment.MiddleCenter:
                    titleP.X = (TitlePanel.Width - titleP.X - textsize.Width) / 2;
                    titleP.Y = (TitlePanel.Height - textsize.Height) / 2;
                    break;
                case ContentAlignment.MiddleLeft:
                    titleP.Y = (TitlePanel.Height - textsize.Height) / 2;
                    break;
                case ContentAlignment.MiddleRight:
                    titleP.X = TitlePanel.Width - textsize.Width - CloseButton.Width - 5;
                    titleP.Y = (TitlePanel.Height - textsize.Height) / 2;
                    break;
            }
            g.DrawString(Text, Font, new SolidBrush(ForeColor) , titleP);
        }
    }
}
