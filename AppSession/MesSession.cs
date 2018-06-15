﻿using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Protocol;

namespace EsayCare.MES
{
    public class MesSession : AppSession<MesSession, MesRequestInfo>
    {

        /// <summary>
        /// 唯一码
        /// </summary>
        public string SN { get; set; }

        protected override void OnInit()
        {
            base.OnInit();
            Logger.Info("新增连接：" + this.RemoteEndPoint.ToString());
        }
        protected override void OnSessionStarted()
        {
            base.OnSessionStarted();
            GlobalData.currentMesSession = this;
            DelegateState.NewSessionConnected?.Invoke(this);
        }
        protected override void HandleException(Exception e)
        {
            base.HandleException(e);
            GlobalData.currentMesSession = null;
            Logger.Debug("异常信息：" + e.Message);
        }
        protected override void HandleUnknownRequest(MesRequestInfo requestInfo)
        {
            base.HandleUnknownRequest(requestInfo);
            Logger.Debug("未知请求：" + requestInfo.Key + requestInfo.Body);
        }
        /// <summary>
        /// 连接关闭
        /// </summary>
        /// <param name="reason"></param>
        protected override void OnSessionClosed(CloseReason reason)
        {
            base.OnSessionClosed(reason);
            GlobalData.currentMesSession = null;
            DelegateState.SessionClosed?.Invoke(this, reason); 
        }
    }
}
