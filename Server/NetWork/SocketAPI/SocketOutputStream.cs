/********************************************************************************
 *	文件名：SocketOutputStream.cs
 *	全路径：	\NetWork\SocketAPI\SocketOutputStream.cs
 *	创建人：	王华
 *	创建时间：2013-11-29
 *
 *	功能说明： Socket的应用层输出缓冲区
 *	       
 *	修改记录：
*********************************************************************************/

using System;
#if UNITY_WP8
using UnityPortSocket;
#else
using System.Net.Sockets;
#endif

#pragma warning disable

namespace SPacket.SocketInstance
{
    public class SocketOutputStream
    {
        public const bool FALSE = false;
        public const bool TRUE = true;
        public const uint SOCKET_ERROR = 0xFFFFFFFF;
        public const uint DEFAULT_SOCKET_OUTPUT_BUFFER_SIZE = 1024 * 8;
        public const uint DISCONNECT_SOCKET_OUTPUT_BUFFER_SIZE = 1024 * 20;

        public SocketOutputStream(SocketInstance sock,
                          uint BufferLen = DEFAULT_SOCKET_OUTPUT_BUFFER_SIZE,
                          uint MaxBufferLen = DISCONNECT_SOCKET_OUTPUT_BUFFER_SIZE)
        {
            m_pSocket = sock;
            m_BufferLen = BufferLen;
            m_MaxBufferLen = MaxBufferLen;
            m_Head = 0;
            m_Tail = 0;
            m_Buffer = new Byte[m_BufferLen];
            m_BufferTemp = new Byte[m_BufferLen];
        }

        void ClearBufferTemp()
        {
            if (m_BufferTemp != null)
            {
                int nCount = m_BufferTemp.Length;
                Array.Clear(m_BufferTemp, 0, nCount);
            }
        }

        public uint Write(Byte[] buf, uint len)
        {
            uint nFree = ((m_Head <= m_Tail) ? (m_BufferLen - m_Tail + m_Head - 1) : (m_Head - m_Tail - 1));

            if (len >= nFree)
            {
                if (!Resize(len - nFree + 1))
                    return 0;
            }

            if (m_Head <= m_Tail)
            {
                if (m_Head == 0)
                {
                    nFree = m_BufferLen - m_Tail - 1;
                    // memcpy(&m_Buffer[m_Tail], buf, len);                  
                    for (int i = 0; i < len; ++i)
                    {
                        m_Buffer[m_Tail + i] = buf[i];
                    }
                }
                else
                {
                    nFree = m_BufferLen - m_Tail;
                    if (len <= nFree)
                    {
                        //memcpy(&m_Buffer[m_Tail], buf, len);
                        for (int i = 0; i < len; ++i)
                        {
                            m_Buffer[m_Tail + i] = buf[i];
                        }
                    }
                    else
                    {
                        //memcpy(&m_Buffer[m_Tail], buf, nFree);
                        for (int i = 0; i < nFree; ++i)
                        {
                            m_Buffer[m_Tail + i] = buf[i];
                        }
                        for (int i = 0; i < len - nFree; ++i)
                        {
                            m_Buffer[i] = buf[nFree + i];
                        }
                        // memcpy(m_Buffer, &buf[nFree], len - nFree);
                    }
                }
            }
            else
            {
                // memcpy(&m_Buffer[m_Tail], buf, len);
                for (int i = 0; i < len; ++i)
                {
                    m_Buffer[m_Tail + i] = buf[i];
                }
            }

            m_Tail = (m_Tail + len) % m_BufferLen;

            return len;
        }

        public uint Flush()
        {

            if (m_pSocket == null) return 0;

            uint nFlushed = 0;
            uint nSent = 0;
            uint nLeft;
            SocketFlags flag = SocketFlags.None;

            if (m_BufferLen > m_MaxBufferLen)
            {
                Initsize();
                return SOCKET_ERROR;
            }
            try
            {
                if (m_Head < m_Tail)
                {
                    nLeft = m_Tail - m_Head;

                    while (nLeft > 0)
                    {
                        ClearBufferTemp();
                        for (int i = 0; i < nLeft; ++i)
                        {
                            m_BufferTemp[i] = m_Buffer[m_Head + i];
                        }
                        nSent = m_pSocket.Send(m_BufferTemp, (int)nLeft, flag);
                        //LogModule.DebugLog(nSent.ToString());
                        //if (nSent==SOCKET_ERROR_WOULDBLOCK) return 0 ; 
                        if (nSent == SOCKET_ERROR) return SOCKET_ERROR;
                        if (nSent == 0) return 0;

                        nFlushed += nSent;
                        nLeft -= nSent;
                        m_Head += nSent;
                    }



                }
                else if (m_Head > m_Tail)
                {
                    nLeft = m_BufferLen - m_Head;

                    while (nLeft > 0)
                    {
                        ClearBufferTemp();
                        for (int i = 0; i < nLeft; ++i)
                        {
                            m_BufferTemp[i] = m_Buffer[m_Head + i];
                        }

                        nSent = m_pSocket.Send(m_BufferTemp, (int)nLeft, flag);
                        //if (nSent==SOCKET_ERROR_WOULDBLOCK) return 0 ; 
                        if (nSent == SOCKET_ERROR) return SOCKET_ERROR - 3;
                        if (nSent == 0) return 0;

                        nFlushed += nSent;
                        nLeft -= nSent;
                        m_Head += nSent;
                    }

                    //			Assert( m_Head == m_BufferLen );

                    m_Head = 0;

                    nLeft = m_Tail;

                    while (nLeft > 0)
                    {
                        ClearBufferTemp();
                        for (int i = 0; i < nLeft; ++i)
                        {
                            m_BufferTemp[i] = m_Buffer[m_Head + i];
                        }

                        nSent = m_pSocket.Send(m_BufferTemp, (int)nLeft, flag);
                        //if (nSent==SOCKET_ERROR_WOULDBLOCK) return 0 ; 
                        if (nSent == SOCKET_ERROR) return SOCKET_ERROR;
                        if (nSent == 0) return 0;

                        nFlushed += nSent;
                        nLeft -= nSent;
                        m_Head += nSent;
                    }


                }

            }
            catch
            {
                if (nSent > 0)
                {
                    m_Head += nSent;
                }
            }

            m_Head = m_Tail = 0;

            return nFlushed;

        }
        public void Initsize(uint BufferLen = DEFAULT_SOCKET_OUTPUT_BUFFER_SIZE)
        {
            m_Head = 0;
            m_Tail = 0;
            if (BufferLen > m_MaxBufferLen)
            {
                BufferLen = m_MaxBufferLen;
            }

            m_Buffer = new Byte[BufferLen];
            m_BufferLen = BufferLen;
        }
        public bool Resize(uint size)
        {

            uint orgSize = size;

            size = Math.Max(size, (uint)(m_BufferLen >> 1));
            uint newBufferLen = m_BufferLen + size;
            uint len = Length();

            if (size < 0)
            {
                if (newBufferLen < 0 || newBufferLen < len)
                    return false;
            }

            Byte[] newBuffer = new Byte[newBufferLen];
            if (newBuffer == null)
                return false;

            if (m_Head < m_Tail)
            {
                // memcpy(newBuffer, &m_Buffer[m_Head], m_Tail - m_Head);
                for (int i = 0; i < m_Tail - m_Head; ++i)
                {
                    newBuffer[i] = m_Buffer[m_Head + i];
                }
            }
            else if (m_Head > m_Tail)
            {
                //memcpy(newBuffer, &m_Buffer[m_Head], m_BufferLen - m_Head);
                for (int i = 0; i < m_BufferLen - m_Head; ++i)
                {
                    newBuffer[i] = m_Buffer[m_Head + i];
                }

                //memcpy(&newBuffer[m_BufferLen - m_Head], m_Buffer, m_Tail);
                for (int i = 0; i < m_Tail; ++i)
                {
                    newBuffer[m_BufferLen - m_Head + i] = m_Buffer[i];
                }
            }
            m_Buffer = newBuffer;
            m_BufferLen = newBufferLen;
            m_Head = 0;
            m_Tail = len;

            return true;
        }

        public uint Length()
        {
            if (m_Head < m_Tail)
                return m_Tail - m_Head;

            else if (m_Head > m_Tail)
                return m_BufferLen - m_Head + m_Tail;

            return 0;
        }




        public void CleanUp()
        {
            m_Head = 0;
            m_Tail = 0;
        }

        SocketInstance m_pSocket;
        Byte[] m_Buffer = null;
        Byte[] m_BufferTemp = null;   //临时缓存，解决new的GC问题

        uint m_BufferLen;
        uint m_MaxBufferLen;
        uint m_Head;
        uint m_Tail;
    }
}
