using SuperSocket.SocketBase.Command;
using System;


namespace EsayCare.MES
{
    /// <summary>
    /// 产品是否进工位请求处理类
    /// </summary>
    public class ISR : CommandBase<MesSession, MesRequestInfo>
    {
        public override void ExecuteCommand(MesSession session, MesRequestInfo requestInfo)
        {
            if (!GlobalData.CheckMesRequestInfo(session, requestInfo, CheckType.Device)) return;

            if (requestInfo.TData.EquipmentID == GlobalData.CH_1_DeviceID)//彩盒线齐套---[是否进该工位请求] 
            {
                DelegateState.ServerStateInfo?.Invoke(" 接收 >> " + requestInfo.Data);
                Console.WriteLine(DateTime.Now.ToString() + " 接收>> " + requestInfo.Data);
                IsIntoStation(session, requestInfo);
            }
            else
            {
                GlobalData.KeyWordIsNullRecv(session, requestInfo.TData, "The current input Equipment:" + requestInfo.TData.EquipmentID + " is not in station ;///");
                session.Logger.Error("当前设备[" + requestInfo.TData + "]不应出现在该工站!");
                return;
            }
        }

        #region 彩盒线业务逻辑处理

        /// <summary>
        /// 彩盒是否进入该工位
        /// </summary>
        /// <param name="sN"></param>
        private void IsIntoStation(MesSession _session, MesRequestInfo _requestInfo)
        {
            if (_requestInfo.TData.CheckResult == CheckResultCode.OK.ToString())
            { 
                _requestInfo.MsgColor = ColorHelper.MsgGray;
                _requestInfo.Msg  = "请开始扫描彩盒ID条码.";
                DelegateState.CHDriverWorkStateChange?.Invoke(true);
            }
            else
            { 
                _requestInfo.MsgColor = ColorHelper.MsgOrange;
                _requestInfo.Msg = "设备未具备开工条件.";
            }
            DelegateState.NewRequestReceived?.Invoke(_session, _requestInfo); 
        }
         
        #endregion
    }
}
