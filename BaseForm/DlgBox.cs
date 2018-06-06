 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime;
using System.Text;
using System.Windows.Forms;

namespace EsayCare.MES
{
    public class DlgBox
    {
        /// <summary>
        /// 设置消息框大小
        /// </summary>
        /// <param name="dlg">消息框</param>
        /// <param name="text">显示文本</param>
        private static void SetDlgSize(DlgBase dlg, string text)
        {
            byte[] strBytes = Encoding.Default.GetBytes(text);
            int column = strBytes.Count() / 60 + 1;
            dlg.Width = (column > 1 ? 400 : 400 * strBytes.Count() / 60) + 160;
            dlg.Height = column * 18 + 150;
        }

        /// <summary>
        /// 添加控制按钮
        /// </summary>
        /// <param name="dlg">消息框</param>
        /// <param name="buttons">按钮</param>
        private static void AddDialogButtons(DlgBase dlg, MessageBoxButtons buttons)
        {
            switch (buttons)
            {
                case MessageBoxButtons.OKCancel:
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("取消", "Cancle", 0, null, DialogResult.Cancel));
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("确认", "OK", 1, null, DialogResult.OK));
                    dlg.Width = dlg.Width < 250 ? 250 : dlg.Width;
                    break;
                case MessageBoxButtons.RetryCancel:
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("取消", "Cancle", 0, null, DialogResult.Cancel));
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("重试", "Retry", 1, null, DialogResult.Retry));
                    dlg.Width = dlg.Width < 250 ? 250 : dlg.Width;
                    break;
                case MessageBoxButtons.YesNo:
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("否", "No", 0, null, DialogResult.No));
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("是", "Yes", 1, null, DialogResult.Yes));
                    dlg.Width = dlg.Width < 250 ? 250 : dlg.Width;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("取消", "Cancle", 0, null, DialogResult.Cancel));
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("否", "No", 0, null, DialogResult.No));
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("是", "Yes", 1, null, DialogResult.Yes));
                    dlg.Width = dlg.Width < 350 ? 350 : dlg.Width;
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("忽略", "Ignore", 0, null, DialogResult.Cancel));
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("重试", "Retry", 0, null, DialogResult.No));
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("终止", "Abort", 1, null, DialogResult.Yes));
                    dlg.Width = dlg.Width < 350 ? 350 : dlg.Width;
                    break;
                default:
                    dlg.BottomPane.Controls.Add(dlg.GenComandBtn("确认", "OK", 0, null, DialogResult.OK));
                    dlg.Width = dlg.Width < 250 ? 250 : dlg.Width;
                    break;
            }
        }
        /// <summary>
        /// 添加提示图标
        /// </summary>
        /// <param name="dlg"></param>
        /// <param name="text"></param>
        /// <param name="icon"></param>
        private static void AddDialogMainPaneControls(DlgBase dlg, string text, int icon)
        {
            Label label = new Label();
            label.Text = text;
            label.Font = new Font("微软雅黑", 10);
            label.Size = new Size(dlg.BaseMainPanel.Width - 20, dlg.BaseMainPanel.Height - 20);
            PictureBox pic = new PictureBox();
            pic.Size = new Size(50, 50);
            pic.Location = new Point(20, 15);
            switch (icon)
            {
                case 0:
                    label.Location = new Point(10, 10);
                    dlg.BaseMainPanel.Controls.Add(label);
                    return;
                case 16:
                    pic.Load(dlg.PluginPath + "\\Res\\MessageBoxIcon\\Error.png");
                    break;
                case 32:
                    pic.Load(dlg.PluginPath + "\\Res\\MessageBoxIcon\\Question.png");
                    break;
                case 48:
                    pic.Load(dlg.PluginPath + "\\Res\\MessageBoxIcon\\Warning.png");
                    break;
                case 64:
                    pic.Load(dlg.PluginPath + "\\Res\\MessageBoxIcon\\Information.png");
                    break;
            }
            dlg.Width += 80;
            dlg.BaseMainPanel.Controls.Add(pic);
            label.Location = new Point(86, 20);
            dlg.BaseMainPanel.Controls.Add(label);
        }

        /// <summary>
        /// 显示提示框
        /// </summary>
        /// <param name="text">提示文本</param>
        /// <returns></returns>
        public static DialogResult Show(string text)
        {
            return Show(text, "", MessageBoxButtons.OK);
        }

        /// <summary>
        /// 显示提示框
        /// </summary>
        /// <param name="text">提示内容</param>
        /// <param name="caption">标题</param>
        /// <returns></returns>
        public static DialogResult Show(string text, string caption)
        {
            return Show(text, caption, MessageBoxButtons.OK);
        }

        /// <summary>
        /// 显示提示框
        /// </summary>
        /// <param name="text">提示文本</param>
        /// <param name="caption">标题</param>
        /// <param name="buttons">按钮</param>
        /// <returns></returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return Show(text, caption, buttons, MessageBoxIcon.None);
        }
        /// <summary>
        /// 显示提示框
        /// </summary>
        /// <param name="text">提示文本</param>
        /// <param name="caption">标题</param>
        /// <param name="buttons">按钮</param>
        /// <returns></returns>
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DlgBase dlg = new DlgBase();
            dlg.TopMost = true;
            dlg.Text = caption;
            dlg.BaseMainPanel.BackColor = Color.White;
            SetDlgSize(dlg, text);
            AddDialogButtons(dlg, buttons);
            AddDialogMainPaneControls(dlg, text, (int)icon);
            return dlg.ShowDialog();
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DlgBase dlg = new DlgBase();
            dlg.TopMost = true;
            dlg.Text = caption;
            dlg.BaseMainPanel.BackColor = Color.White;
            SetDlgSize(dlg, text);
            AddDialogButtons(dlg, buttons);
            AddDialogMainPaneControls(dlg, text, (int)icon);
            int index = (int)defaultButton;
            if (dlg.BottomPane.Controls.Count >= index)
                dlg.Controls[index].Focus();
            return dlg.ShowDialog();
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
        {
            return Show(text, caption, buttons, icon, defaultButton);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath)
        {
            return Show(text, caption, buttons, icon, defaultButton);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, bool displayHelpButton)
        {
            return Show(text, caption, buttons, icon, defaultButton);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, HelpNavigator navigator)
        {
            return Show(text, caption, buttons, icon, defaultButton);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, string helpFilePath, string keyword)
        {
            return Show(text, caption, buttons, icon, defaultButton);
        }
        
    }
}
