using System;


namespace EsayCare.MES
{
    public class GlobalData : Object
    {
        //配置文件助手
        public static ConfigHelper CfgHelper = null;
        //日志助手对象
        public static LogHelper Log = null;
        //当前工序类型
        public static string Process;
        //当前工序类型 
        public static string MachineId; 
        public static string EquipmentNO;
        //EQC服务器IP,Port
        public static string EQCServerIP;
        public static string EQCServerPort;
        //MES服务器IP,Port
        public static string MESServerIP;
        public static string MESServerPort;
        //客户网站
        public static string URL;
        //结束符
        public static readonly string EndPoint = "\r\n";
        //空格符
        public static readonly string SpacePoint = " ";

        /// <summary>
        /// 初始化全局数据
        /// </summary>
        public static void InitGlobalData()
        {
            //配置文件对象
            CfgHelper = new ConfigHelper();
            LoadConfig();
            //日志对象
            Log = LogHelper.GetInstence();
            Log.StartLog(LogLevel.DEBUG);

        }

        ~GlobalData()
        {

        }


        /// <summary>
        /// 读取配置参数
        /// </summary>
        public static void LoadConfig()
        {
            //读取配置参数
            MachineId = CfgHelper.GetKeyValue("MachineId");
            Process = CfgHelper.GetKeyValue("Process");
            MESServerIP = CfgHelper.GetKeyValue("MESServerIP");
            MESServerPort = CfgHelper.GetKeyValue("MESServerPort");
            EQCServerIP = CfgHelper.GetKeyValue("EQCServerIP");
            EQCServerPort = CfgHelper.GetKeyValue("EQCServerPort");
            URL = CfgHelper.GetKeyValue("URL");
            EquipmentNO = CfgHelper.GetKeyValue("EquipmentNO"); 

        }
    }
    public class ErrorMessage
    {
        public string ErrorCode { get; set; }

        public string ErrorInfo { get; set; }

        public override string ToString()
        {
            return string.Format("{0}:{1}", ErrorCode, ErrorInfo);
        }
    }
}
