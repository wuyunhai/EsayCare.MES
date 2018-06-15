
using SuperSocket.SocketBase;
using System;
using System.Drawing;

namespace EsayCare.MES
{
    /// <summary>
    /// 委托回调函数 this.Invoke(new ThreadStart(delegate{})) 实现与UI交换
    /// </summary>
    public class DelegateState
    {
        //信息显示GetNextSN
        public delegate void ExecGetNextSNCallBack(string workOrder);
        public delegate void MsgCallBack(Color color, string msg);
        public delegate void CheckMsgCallBack(string msg);
        public delegate void SocketStateCallBack(string msg);
        public delegate void SockeTeartbeatStateCallBack(int num);
        public delegate void SocketConnStateCallBack(string RemoteIp, string TCPUDP);

        public delegate void NewRequestReceivedCallBack(MesSession session, MesRequestInfo requestInfo);
        public delegate void WorkStateDelegate(bool IsWork);

        /// <summary>
        /// 消息提示
        /// </summary>
        public static MsgCallBack MsgView;
        /// <summary>
        /// 工作状态
        /// </summary>
        public static WorkStateDelegate CHDriverWorkStateChange;
        /// <summary>
        /// 发送或接受消息界面UI显示
        /// </summary>
        public static NewRequestReceivedCallBack NewRequestReceived;
        /// <summary>
        /// 消息界面UI显示
        /// </summary>
        public static CheckMsgCallBack CheckMsgInfo;
        /// <summary>
        /// 消息界面UI显示
        /// </summary>
        public static ExecGetNextSNCallBack ExecGetNextSN;

        /// <summary>
        /// 信息显示
        /// </summary>
        public static SocketStateCallBack ServerStateInfo;

        /// <summary>
        /// 心跳检测信息
        /// </summary>
        public static SockeTeartbeatStateCallBack TeartbeatServerStateInfo;

        /// <summary>
        /// 信息显示
        /// </summary>
        public static SocketConnStateCallBack ServerConnStateInfo;


        #region TCP服务

        public delegate void SocketTCPStateCallBack(string msg);
        public delegate void SocketAddTCPuserStateCallBack(MesSession mesSession);
        public delegate void NewSessionConnectedCallBack(MesSession mesSession);
        public delegate void SessionClosedCallBack(MesSession mesSession, CloseReason reason);

        /// <summary>
        /// TCP信息显示
        /// </summary>
        public static SocketTCPStateCallBack ServerTCPStateInfo;
        /// <summary>
        /// TCP添加用户
        /// </summary>
        public static SocketAddTCPuserStateCallBack AddTCPuserStateInfo;
        /// <summary>
        /// 新的连接
        /// </summary>
        public static NewSessionConnectedCallBack NewSessionConnected;
        /// <summary>
        /// 连接关闭
        /// </summary>
        public static SessionClosedCallBack SessionClosed;

        #endregion

    }
}
