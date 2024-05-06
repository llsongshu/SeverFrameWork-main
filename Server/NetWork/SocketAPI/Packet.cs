/********************************************************************************
 *	文件名：Packet.cs
 *	全路径：	\NetWork\SocketAPI\Packet.cs
 *	创建人：	王华
 *	创建时间：2013-11-29
 *
 *	功能说明： 消息包接口类
 *	       
 *	修改记录：
*********************************************************************************/

namespace SPacket.SocketInstance
{
    public enum PACKET_EXE
    {
        PACKET_EXE_ERROR = 0,
        PACKET_EXE_BREAK,
        PACKET_EXE_CONTINUE,
        PACKET_EXE_NOTREMOVE,
        PACKET_EXE_NOTREMOVE_ERROR,
    }

    public interface Ipacket
    {
        uint Execute(PacketDistributed packet);
    }
}
