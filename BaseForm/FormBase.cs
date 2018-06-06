using System.Windows.Forms;

namespace EsayCare.MES
{
    public delegate void LoadingDelegate(string frmName, string msg, bool IsShow);
  
    public partial class FormBase : Form
    {
        /// <summary>
        /// 加载框状态改变
        /// </summary>
        public static event LoadingDelegate OnLoadingChange; 

        /// <summary>
        /// 加载页面显示状态
        /// </summary>
        public static bool IsLoaddingShow = false;
        /// <summary>
        /// 当前网络是否连通
        /// </summary>
        public static bool IsNetConnected = false;
        public FormBase()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示加载框
        /// </summary>
        /// <param name="msg">加载框显示文本</param>
        /// <param name="timeout">超时时间，单位为秒</param>
        protected void ShowLoading(string msg, int timeout = -1)
        {
            if (OnLoadingChange != null)
            {
                OnLoadingChange.Invoke(this.Name, msg, true);
                IsLoaddingShow = true;
            }
        }
        /// <summary>
        /// 隐藏加载框
        /// </summary>
        protected void HideLoading()
        {
            if (OnLoadingChange != null)
            {
                OnLoadingChange.Invoke(this.Name, "", false);
                IsLoaddingShow = false;
            }
        }
    }
     
}
