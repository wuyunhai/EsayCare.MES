using SuperSocket.SocketBase.Command;
using System;
using System.Reflection;
using System.Threading;

namespace EsayCare.MES
{
    /// <summary>
    /// 条码校验/前工序校验
    /// </summary>
    public class SND : CommandBase<MesSession, MesRequestInfo>
    {
        public override void ExecuteCommand(MesSession session, MesRequestInfo requestInfo)
        {
            if (!GlobalData.CheckMesRequestInfo(session, requestInfo, CheckType.DeviceSN)) return;

            DelegateState.ServerStateInfo?.Invoke(" 接收 >> " + requestInfo.Data);
            Console.WriteLine(DateTime.Now.ToString() + " 接收 >> " + requestInfo.Data);
            if (requestInfo.TData.EquipmentID == GlobalData.CH_1_DeviceID)
            {
                GXHProcess(session, requestInfo);
            }
            else
            {
                GlobalData.KeyWordIsNullRecv(session, requestInfo.TData, "The current input Equipment:" + requestInfo.TData.EquipmentID + " is not in station ;///");
                session.Logger.Error("当前设备[" + requestInfo.TData + "]不应出现在该工站!");
                return;
            }
        }

        #region 个性化注液业务逻辑处理

        /// <summary>
        /// TODO：个性化线：01 - 上工序校验
        /// </summary>
        /// <param name="sN"></param>        
        private void GXHProcess(MesSession session, MesRequestInfo requestInfo)
        {
            DelegateState.CheckMsgInfo?.Invoke(requestInfo.TData.CheckResult);

            if (requestInfo.TData.CheckResult == CheckResultCode.OK.ToString())
            {
                try
                {
                    //自动分配仓位过站
                    GlobalData.CheckRoute(requestInfo.TData, "", true, "PASS");
                    if (requestInfo.TData.CheckResult != CheckResult.ERROR.ToString()) //成功  
                    {
                        requestInfo.MsgColor = ColorHelper.MsgGreen;
                        requestInfo.Msg = "MES过站成功.";
                    }
                    else
                    {
                        requestInfo.MsgColor = ColorHelper.MsgRed;
                        requestInfo.Msg = "MES过站失败." + requestInfo.TData.Description;
                    }
                }
                catch (Exception ex)
                {
                    requestInfo.MsgColor = ColorHelper.MsgRed;
                    requestInfo.Msg = "执行过站方法出错>>" + ex.Message;
                }
                DelegateState.NewRequestReceived?.Invoke(session, requestInfo);
                // 加载下一条 
                DelegateState.ExecGetNextSN?.Invoke(requestInfo.TData.WO);
            }
            else
            {
                for (int i = 3; i > 0; i--)
                {
                    requestInfo.MsgColor = ColorHelper.MsgRed;
                    requestInfo.Msg = "彩盒SN校验失败，【" + i.ToString() + "】秒后重新下发.";
                    DelegateState.NewRequestReceived?.Invoke(session, requestInfo);
                    Thread.Sleep(1000);
                } 
                requestInfo.TData.CheckResult = null;
                string msg = MethodBase.GetCurrentMethod().DeclaringType.Name + " " + JsonHelper.Serialize(requestInfo.TData) + Environment.NewLine;
                session.Send(msg);

                requestInfo.MsgColor = ColorHelper.MsgOrange;
                requestInfo.Msg = "条码已重新下发.";
                DelegateState.NewRequestReceived?.Invoke(session, requestInfo);
            }

        }


        #endregion
    }
}
