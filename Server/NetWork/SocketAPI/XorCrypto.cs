/********************************************************************************
 *	文件名：XorCrypto.cs
 *	全路径：	\NetWork\SocketAPI\XorCrypto.cs
 *	创建人：	房迪
 *	创建时间：2014-08-04
 *
 *	功能说明： 消息包加密
 *	       
 *	修改记录：
*********************************************************************************/

using System;
#if UNITY_WP8
using UnityPort;
#endif

namespace SPacket.SocketInstance
{
    public class XorCrypto
    {
        //1E95A51FD4C38CD68428186BC5C3E26F
#if UNITY_WP8
        static private byte[] s_Key = PortUtil.StringToASCII("1E95A51FD4C38CD68428186BC5C3E26F");
#else
        static private byte[] s_Key = System.Text.Encoding.ASCII.GetBytes("1E95A51FD4C38CD68428186BC5C3E26F");
#endif
        static private int s_KeySize = s_Key.Length;
        private static void _Xor(Byte[] Buf, UInt32 nSize)
        {
            for (int i = 0; i < nSize; ++i)
            {
                Buf[i] ^= s_Key[i % s_KeySize];
            }
        }
        public static void XorEncrypt(Byte[] Buf, UInt32 nSize)
        {
            _Xor(Buf, nSize);
        }
        public static void XorDecrypt(Byte[] Buf, UInt32 nSize)
        {
            _Xor(Buf, nSize);
        }
    }
}
