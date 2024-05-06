/********************************************************************************
 *	文件名：SocketInputStream.cs
 *	全路径：	\NetWork\SocketAPI\SocketInputStream.cs
 *	创建人：	王华
 *	创建时间：2013-11-29
 *
 *	功能说明： Socket的应用层输入缓冲区
 *	       
 *	修改记录：
*********************************************************************************/

using System;
#if UNITY_WP8
using UnityPortSocket;
#else
#endif

namespace SPacket.SocketInstance
{
    public class SocketInputStream
    {
        public const uint SOCKET_ERROR = 0xFFFFFFFF;
        public const uint DEFAULT_SOCKET_INPUT_BUFFER_SIZE = 1024 * 256;
        public const uint MAX_SOCKET_INPUT_BUFFER_SIZE = 1024 * 512;

        public SocketInputStream(SocketInstance socket,
            uint BufferLen = DEFAULT_SOCKET_INPUT_BUFFER_SIZE,
            uint MaxBufferLen = MAX_SOCKET_INPUT_BUFFER_SIZE)
        {
            m_pSocket = socket;
            m_BufferLen = BufferLen;
            m_MaxBufferLen = MaxBufferLen;
            m_Head = 0;
            m_Tail = 0;
            m_Buffer = new Byte[BufferLen];
            m_BufferTemp = new Byte[BufferLen];
        }
        void ClearBufferTemp()
        {
            if (m_BufferTemp != null)
            {
                int nCount = m_BufferTemp.Length;
                Array.Clear(m_BufferTemp, 0, nCount);
            }
        }

        public uint Length()
        {
            if (m_Head < m_Tail)
                return m_Tail - m_Head;

            else if (m_Head > m_Tail)
                return m_BufferLen - m_Head + m_Tail;

            return 0;
        }

        public uint Read(Byte[] buf, uint len)
        {

            if (len == 0)
                return 0;

            if (len > Length())
                return 0;

            if (m_Head < m_Tail)
            {
                for (uint i = 0; i < len; ++i)
                {
                    buf[i] = m_Buffer[m_Head + i];
                }
            }
            else
            {
                uint rightLen = m_BufferLen - m_Head;
                if (len <= rightLen)
                {
                    for (uint i = 0; i < len; ++i)
                    {
                        buf[i] = m_Buffer[m_Head + i];
                    }
                }
                else
                {
                    for (uint i = 0; i < rightLen; ++i)
                    {
                        buf[i] = m_Buffer[m_Head + i];
                    }
                    for (uint i = 0; i < len - rightLen; ++i)
                    {
                        buf[i + rightLen] = m_Buffer[i];
                    }
                }
            }

            m_Head = (m_Head + len) % m_BufferLen;

            return len;
        }
        public bool Peek(Byte[] buf, uint len)
        {

            if (len == 0)
                return false;

            if (len > Length())
                return false;

            if (m_Head < m_Tail)
            {

                for (uint i = 0; i < len; ++i)
                {
                    buf[i] = m_Buffer[m_Head + i];
                }

            }
            else
            {
                uint rightLen = m_BufferLen - m_Head;
                if (len <= rightLen)
                {

                    for (uint i = 0; i < len; ++i)
                    {
                        buf[i] = m_Buffer[m_Head + i];
                    }
                }
                else
                {
                    for (uint i = 0; i < rightLen; ++i)
                    {
                        buf[i] = m_Buffer[m_Head + i];
                    }
                    for (uint i = 0; i < len - rightLen; ++i)
                    {
                        buf[rightLen + i] = m_Buffer[i];
                    }
                }
            }

            return true;
        }
        public bool Skip(uint len)
        {
            if (len == 0)
                return false;

            if (len > Length())
                return false;

            m_Head = (m_Head + len) % m_BufferLen;

            return true;
        }

        public uint Fill()
        {
            uint nFilled = 0;
            uint nReceived = 0;
            uint nFree = 0;

            if (m_pSocket == null) return 0;

            if (m_Head <= m_Tail)
            {
                if (m_Head == 0)
                {
                    //
                    // H   T		LEN=10
                    // 0123456789
                    // abcd......
                    //

                    nReceived = 0;
                    nFree = m_BufferLen - m_Tail - 1;
                    if (nFree != 0)
                    {
                        ClearBufferTemp();
                        nReceived = m_pSocket.receive(m_BufferTemp, (int)nFree);
                        if (nReceived == SOCKET_ERROR) return SOCKET_ERROR;
                        for (int i = 0; i < nReceived; ++i)
                        {
                            m_Buffer[m_Tail + i] = m_BufferTemp[i];
                        }

                        // if (nReceived==SOCKET_ERROR_WOULDBLOCK) return 0 ; 
                        // if (nReceived==SOCKET_ERROR) return SOCKET_ERROR-1 ;


                        m_Tail += nReceived;
                        nFilled += nReceived;
                    }

                    if (nReceived == nFree)
                    {
                        uint available = m_pSocket.available();
                        if (available > 0)
                        {
                            if ((m_BufferLen + available + 1) > m_MaxBufferLen)
                            {
                                Initsize();
                                return SOCKET_ERROR;
                            }
                            if (!Resize(available + 1))
                                return 0;

                            ClearBufferTemp();
                            nReceived = m_pSocket.receive(m_BufferTemp, (int)available);
                            if (nReceived == SOCKET_ERROR) return SOCKET_ERROR;
                            for (int i = 0; i < nReceived; ++i)
                            {
                                m_Buffer[m_Tail + i] = m_BufferTemp[i];
                            }

                            // if (nReceived==SOCKET_ERROR_WOULDBLOCK) return 0 ; 
                            // if (nReceived==SOCKET_ERROR) return SOCKET_ERROR-4 ;
                            //if (nReceived==0) return SOCKET_ERROR-5;

                            m_Tail += nReceived;
                            nFilled += nReceived;
                        }
                    }

                }
                else
                {
                    //
                    //    H   T		LEN=10
                    // 0123456789
                    // ...abcd...
                    //

                    nFree = m_BufferLen - m_Tail;

                    ClearBufferTemp();
                    nReceived = m_pSocket.receive(m_BufferTemp, (int)nFree);
                    if (nReceived == SOCKET_ERROR) return SOCKET_ERROR;

                    for (int i = 0; i < nReceived; ++i)
                    {
                        m_Buffer[m_Tail + i] = m_BufferTemp[i];
                    }

                    //nReceived = m_pSocket->receive( &m_Buffer[m_Tail], nFree );
                    // if( nReceived==SOCKET_ERROR_WOULDBLOCK ) return 0 ; 
                    // if( nReceived==SOCKET_ERROR ) return SOCKET_ERROR-6 ;
                    // if( nReceived==0 ) return SOCKET_ERROR-7 ;

                    m_Tail = (m_Tail + nReceived) % m_BufferLen;
                    nFilled += nReceived;

                    if (nReceived == nFree)
                    {
                        //				Assert( m_Tail == 0 );

                        nReceived = 0;
                        nFree = m_Head - 1;
                        if (nFree != 0)
                        {
                            ClearBufferTemp();
                            nReceived = m_pSocket.receive(m_BufferTemp, (int)nFree);
                            if (nReceived == SOCKET_ERROR) return SOCKET_ERROR;

                            for (int i = 0; i < nReceived; ++i)
                            {
                                m_Buffer[i] = m_BufferTemp[i];
                            }

                            //  nReceived = m_pSocket->receive( &m_Buffer[0] , nFree );
                            // if( nReceived==SOCKET_ERROR_WOULDBLOCK ) return 0 ; 
                            // if( nReceived==SOCKET_ERROR ) return SOCKET_ERROR -8;
                            // if( nReceived==0 ) return SOCKET_ERROR-9 ;

                            m_Tail += nReceived;
                            nFilled += nReceived;
                        }

                        if (nReceived == nFree)
                        {
                            uint available = m_pSocket.available();
                            if (available > 0)
                            {
                                if ((m_BufferLen + available + 1) > m_MaxBufferLen)
                                {
                                    Initsize();
                                    return SOCKET_ERROR;
                                }
                                if (!Resize(available + 1))
                                    return 0;

                                ClearBufferTemp();
                                nReceived = m_pSocket.receive(m_BufferTemp, (int)available);
                                if (nReceived == SOCKET_ERROR) return SOCKET_ERROR;

                                for (int i = 0; i < nReceived; ++i)
                                {
                                    m_Buffer[m_Tail + i] = m_BufferTemp[i];
                                }

                                // nReceived = m_pSocket->receive( &m_Buffer[m_Tail] , available );
                                //if (nReceived==SOCKET_ERROR_WOULDBLOCK) return 0 ; 
                                //if (nReceived==SOCKET_ERROR) return SOCKET_ERROR-11 ;
                                // if (nReceived==0) return SOCKET_ERROR-12;

                                m_Tail += nReceived;
                                nFilled += nReceived;
                            }
                        }
                    }

                }

            }
            else
            {
                //
                //     T  H		LEN=10
                // 0123456789
                // abcd...efg
                //

                nReceived = 0;
                nFree = m_Head - m_Tail - 1;
                if (nFree != 0)
                {
                    ClearBufferTemp();
                    nReceived = m_pSocket.receive(m_BufferTemp, (int)nFree);
                    if (nReceived == SOCKET_ERROR) return SOCKET_ERROR;

                    for (int i = 0; i < nReceived; ++i)
                    {
                        m_Buffer[m_Tail + i] = m_BufferTemp[i];
                    }

                    // nReceived = m_pSocket->receive( &m_Buffer[m_Tail], nFree ) ;
                    // if( nReceived==SOCKET_ERROR_WOULDBLOCK ) return 0 ; 
                    //if( nReceived==SOCKET_ERROR ) return SOCKET_ERROR-13 ;
                    //if( nReceived==0 ) return SOCKET_ERROR-14 ;

                    m_Tail += nReceived;
                    nFilled += nReceived;
                }
                if (nReceived == nFree)
                {
                    uint available = m_pSocket.available();
                    if (available > 0)
                    {
                        if ((m_BufferLen + available + 1) > m_MaxBufferLen)
                        {
                            Initsize();
                            return SOCKET_ERROR;
                        }
                        if (!Resize(available + 1))
                            return 0;
                        ClearBufferTemp();
                        nReceived = m_pSocket.receive(m_BufferTemp, (int)available);
                        if (nReceived == SOCKET_ERROR) return SOCKET_ERROR;

                        for (int i = 0; i < nReceived; ++i)
                        {
                            m_Buffer[m_Tail + i] = m_BufferTemp[i];
                        }

                        // nReceived = m_pSocket->receive( &m_Buffer[m_Tail], available ) ;
                        // if( nReceived==SOCKET_ERROR_WOULDBLOCK ) return 0 ; 
                        // if( nReceived==SOCKET_ERROR ) return SOCKET_ERROR-16 ;
                        // if( nReceived==0 ) return SOCKET_ERROR-17 ;

                        m_Tail += nReceived;
                        nFilled += nReceived;
                    }
                }

            }

            return nFilled;
        }
        public void Initsize(uint BufferSize = DEFAULT_SOCKET_INPUT_BUFFER_SIZE)
        {
            m_Head = 0;
            m_Tail = 0;

            if (BufferSize > m_MaxBufferLen)
            {
                BufferSize = m_MaxBufferLen;
            }

            m_Buffer = new Byte[BufferSize];
            m_BufferLen = BufferSize;
        }
        public bool Resize(uint size)
        {
            size = Math.Max(size, (uint)(m_BufferLen >> 1));
            uint newBufferLen = (uint)(m_BufferLen + size);
            uint len = Length();

            if (size < 0)
            {
                if (newBufferLen < 0 || newBufferLen < len)
                    return false;
            }

            Byte[] newBuffer = new Byte[newBufferLen];
            if (m_Head < m_Tail)
            {
                //memcpy(newBuffer, &m_Buffer[m_Head], m_Tail - m_Head);
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
                for (int i = 0; i < m_BufferLen - m_Head; ++i)
                {
                    newBuffer[m_BufferLen - m_Head + i] = m_Buffer[i];
                }
            }

            // delete[] m_Buffer;

            m_Buffer = newBuffer;
            m_BufferLen = newBufferLen;
            m_Head = 0;
            m_Tail = len;

            return true;
        }
        public void CleanUp()
        {
            m_Head = 0;
            m_Tail = 0;
        }
        SocketInstance m_pSocket;
        Byte[] m_Buffer = null;
        Byte[] m_BufferTemp = null;     //临时缓存，解决new的GC问题

        uint m_BufferLen;
        uint m_MaxBufferLen;

        uint m_Head;
        uint m_Tail;
    }
}
