/********************************************************************************
 *	文件名：Socket.cs
 *	全路径：	\NetWork\SocketAPI\Socket.cs
 *	创建人：	王华
 *	创建时间：2013-11-29
 *
 *	功能说明： Socket类
 *	       
 *	修改记录：
*********************************************************************************/

using System;
#if UNITY_WP8
using UnityPortSocket;
#else
using System.Net.Sockets;
#endif
using SPacket.Socket_API;

namespace SPacket.SocketInstance
{
    public class SocketInstance
    {
        public uint Send(Byte[] buf, int nLen, SocketFlags flags = SocketFlags.None)
        {
            return SocketAPI.Send(m_SocketID, buf, (uint)nLen, flags);
        }
        public uint receive(Byte[] buf, int nLen, uint flags = 0)
        {
            return SocketAPI.Recv(m_SocketID, buf, (uint)nLen, flags);
        }
        public void close()
        {
            if (IsValid)
            {
                SocketAPI.Close(m_SocketID);
                m_SocketID = null;
            }
        }
        public uint available()
        {
            return SocketAPI.available(m_SocketID);
        }
        public string connect(string IP, int port)
        {
            m_host = IP;
            m_port = port;
            string results = "";
            m_SocketID = SocketAPI.Connect(m_host, m_port, ref results);
            return results;
        }
        public bool IsValid
        {
            get { return m_SocketID != null; }
        }
        public bool IsConnected
        {
            get { return m_SocketID != null && m_SocketID.Connected; }
        }
        public bool IsCanSend()
        {
            if (m_SocketID != null)
            {
                if (m_SocketID.Poll(0, SelectMode.SelectWrite))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsCanReceive()
        {
            if (m_SocketID != null)
            {
                if (m_SocketID.Poll(0, SelectMode.SelectRead))
                {
                    return true;
                }
            }
            return false;
        }

        private Socket m_SocketID;

        private string m_host;
        private int m_port;
    }
}
