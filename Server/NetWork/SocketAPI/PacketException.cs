/********************************************************************************
 *	文件名：PacketException.cs
 *	全路径：	\NetWork\SocketAPI\PacketException.cs
 *	创建人：	王华
 *	创建时间：2013-11-29
 *
 *	功能说明： 消息包异常类
 *	       
 *	修改记录：
*********************************************************************************/

using System.IO;

namespace SPacket.SocketInstance
{
    public class PacketException : IOException
    {
        internal PacketException(string message)
            : base(message)
        {
        }

        internal static PacketException PacketReadError(string msg)
        {
            return new PacketException("PacketException ReadError:" + msg);
        }

        internal static PacketException PacketExecuteError(string msg)
        {
            return new PacketException("PacketException ExecuteError:" + msg);
        }

        internal static PacketException PacketCreateError(string msg)
        {
            return new PacketException("PacketException CreateError:" + msg);
        }

    }
}
