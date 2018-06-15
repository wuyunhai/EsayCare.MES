using CCWin.SkinControl;
using DM_API;
using System;
using System.Data;
using System.Drawing;

namespace EsayCare.MES
{
    public class GlobalData : Object
    {
        #region var

        // 当前Server
        public static MesServer currentMesServer;
        // 当前Session
        public static MesSession currentMesSession; 
        //配置文件助手
        public static ConfigHelper CfgHelper = null;
        //日志助手对象
        public static LogHelper Log = null;
        //当前工序类型
        public static string Process;
        //当前工序类型 
        public static string MachineId;
        public static string CH_1_DeviceID;
        //EQC服务器IP,Port
        public static string EQCServerIP;
        public static string EQCServerPort; 
        //MES服务器IP,Port
        public static string MESServerIP;
        public static string MESServerPort;
        //客户网站
        public static string URL;
        //Panel 颜色方案
        public static PanelColorTable PnlColorTable;
        //Panel 颜色方案
        public static PanelColorTable PnlColor;

        #endregion

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

        public const string ProtocolFormalError = "通讯协议错误(正确格式为：三位功能码 + 空格 + json字符串 + 回车换行符号).";

        #region 校验接收数据是否正确

        /// <summary>
        /// 校验接收数据是否正确
        /// </summary>
        /// <param name="session"></param>
        /// <param name="requestInfo"></param>
        /// <param name="recvTransData"></param>
        /// <returns></returns>
        public static bool CheckMesRequestInfo(MesSession session, MesRequestInfo requestInfo, CheckType checkType)
        {
            if (requestInfo.TData == null)
            {
                GlobalData.KeyWordIsNullRecv(session, requestInfo.TData, "RequestInfo");
                session.Logger.Error("RequestInfo is not json format !");
                return false;
            }

            if (string.IsNullOrWhiteSpace(requestInfo.TData.EquipmentID))
            {
                GlobalData.KeyWordIsNullRecv(session, requestInfo.TData, "EquipmentID");
                session.Logger.Error("EquipmentID error !");
                return false;
            }
            if (checkType == CheckType.DeviceSN && string.IsNullOrWhiteSpace(requestInfo.TData.SN))
            {
                GlobalData.KeyWordIsNullRecv(session, requestInfo.TData, "SN");
                session.Logger.Error("SN error !");
                return false;
            }
            return true;
        }

        #endregion

        #region 关键字段为空时处理方法

        /// <summary>
        /// 关键字段为空时处理方法
        /// </summary>
        /// <param name="_session"></param>
        /// <param name="_transData"></param>
        /// <param name="_keyWord"></param>
        public static void KeyWordIsNullRecv(MesSession _session, TransmitData _transData, string _keyWord)
        {

            _transData.CheckResult = CheckResult.ERROR.ToString();
            _transData.Description = _keyWord + " is null or white space or format error ?";
            string msg = _transData.Func + " " + JsonHelper.Serialize(_transData) + Environment.NewLine;
            _session.Send(msg);
            _session.Logger.Error(_transData.CheckResult + "---" + _transData.Description);
        }

        #endregion

        #region 【上工序校验】

        /// <summary>
        /// 上工序校验
        /// </summary>
        /// <param name="session"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool CheckRouteOnlyCheck(TransmitData data)
        {
            try
            {
                //上工序校验
                DM_SFCInterface DM_SFC = new DM_SFCInterface();
                DataTable dt = DM_SFC.SFC_DM_CheckRouteOnlyCheck(data.SN, data.EquipmentID, "", "");//FAIL
                string CheckStatus = dt.Rows[0][0].ToString().ToString();
                string ReturnMsg = dt.Rows[0][1].ToString().ToString();
                if (CheckStatus == "1") // 成功 
                {
                    data.CheckResult = CheckResult.OK.ToString();
                    return true;
                }
                else
                {
                    data.CheckResult = CheckResult.ERROR.ToString();
                    data.Description = ReturnMsg;
                    return false;
                }
            }
            catch (Exception e)
            {
                data.CheckResult = CheckResult.ERROR.ToString();
                data.Description = e.Message;
                return false;
            }
        }

        #endregion 

        #region 【ByPass工序过站】

        /// <summary>
        /// 上工序校验
        /// </summary>
        /// <param name="session"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool CheckRoute(TransmitData data, string deviceID, bool first, string Result)
        {
            try
            {
                //上工序校验
                DM_SFCInterface DM_SFC = new DM_SFCInterface();
                DataTable dt = DM_SFC.SFC_DM_CheckRoute(data.SN, string.IsNullOrWhiteSpace(deviceID) ? data.EquipmentID : deviceID, first ? data.WO : "", Result);//FAIL
                string CheckStatus = dt.Rows[0][0].ToString().ToString();
                string ReturnMsg = dt.Rows[0][1].ToString().ToString();
                if (CheckStatus == "1") // 成功 
                {
                    data.CheckResult = CheckResult.OK.ToString();
                    return true;
                }
                else
                {
                    data.CheckResult = CheckResult.ERROR.ToString();
                    data.Description = ReturnMsg;
                    return false;
                }
            }
            catch (Exception e)
            {
                data.CheckResult = CheckResult.ERROR.ToString();
                data.Description = e.Message;
                return false;
            }
        }

        #endregion 


        /// <summary>
        /// 读取配置参数
        /// </summary>
        public static void LoadConfig()
        {
            //颜色方案1
            PnlColorTable = new PanelColorTable();
            PnlColorTable.CaptionBackHover = Color.Gainsboro;
            PnlColorTable.CaptionBackNormal = Color.Gainsboro;
            PnlColorTable.CaptionBackPressed = Color.Gainsboro;
            PnlColorTable.Border = Color.Gainsboro;
            //颜色方案2
            PnlColor = new PanelColorTable();
            PnlColor.CaptionBackHover = Color.WhiteSmoke;
            PnlColor.CaptionBackNormal = Color.WhiteSmoke;
            PnlColor.CaptionBackPressed = Color.WhiteSmoke;
            PnlColor.CaptionFore = Color.Gray;
            PnlColor.Border = Color.Gainsboro;

            //读取配置参数
            MachineId = CfgHelper.GetKeyValue("MachineId");
            Process = CfgHelper.GetKeyValue("Process");
            MESServerIP = CfgHelper.GetKeyValue("MESServerIP");
            MESServerPort = CfgHelper.GetKeyValue("MESServerPort");
            EQCServerIP = CfgHelper.GetKeyValue("EQCServerIP");
            EQCServerPort = CfgHelper.GetKeyValue("EQCServerPort");
            URL = CfgHelper.GetKeyValue("URL");
            CH_1_DeviceID = CfgHelper.GetKeyValue("CH_1_DeviceID");

        }
    }

    public enum CheckResult
    {
        OK,
        NG,
        ERROR
    }
    public enum CheckType
    {
        DeviceSN,
        Device
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
