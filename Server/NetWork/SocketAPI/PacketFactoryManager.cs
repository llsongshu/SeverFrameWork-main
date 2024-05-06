/********************************************************************************
 *	文件名：PacketFactoryManager.cs
 *	全路径：	NetWork\SocketAPI\PacketFactoryManager.cs
 *	创建人：	王华
 *	创建时间：2013-11-29
 *
 *	功能说明： 消息工厂接口类
 *	       
 *	修改记录：
*********************************************************************************/

using System.Collections.Generic;
#if UNITY_WP8
using UnityPortSocket;
#else
#endif
using System.Collections;

namespace SPacket.SocketInstance
{

    public interface PacketFactory
    {
        MessageID GetPacketID();
    }

    public abstract class PacketFactoryManager
    {

        public abstract bool Init();

        public Ipacket GetPacketHandler(MessageID nMID)
        {
            if (m_HandlerDic.ContainsKey(nMID))
            {
                return m_HandlerDic[nMID] as Ipacket;
            }
            return null;
        }

        public void RemovePacket(Ipacket pPacket)
        {
            if (pPacket == null) return;
        }


        protected void AddFactory(PacketFactory pFactory)
        {
            if (!m_Factories.ContainsKey(pFactory.GetPacketID()))
            {
                m_Factories.Add(pFactory.GetPacketID(), pFactory);
            }
        }

        protected void AddPacketHander(MessageID nMID, Ipacket packetHander)
        {
            if (!m_HandlerDic.ContainsKey(nMID))
            {
                m_HandlerDic.Add(nMID, packetHander);
            }
        }

        protected Hashtable m_Factories = new Hashtable();
        protected Dictionary<MessageID, Ipacket> m_HandlerDic = new Dictionary<MessageID, Ipacket>();

    }


}