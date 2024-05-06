/********************************************************************************
 *	文件名：SocketAPI.cs
 *	全路径：	\NetWork\SocketAPI\SocketAPI.cs
 *	创建人：	王华
 *	创建时间：2013-11-29
 *
 *	功能说明： SocketAPI类，提供了连接，收，发几个接口
 *	       
 *	修改记录：王迪 2014.02.14 注释掉ClientSocket.Disconnect(false);
*********************************************************************************/

using System;
using System.Net;
#if UNITY_WP8
using UnityPortSocket;
#else
using System.Net.Sockets;
#endif
using System.Security;


namespace SPacket.Socket_API
{
    public class SocketAPI
    {
        public static Socket Connect(string ServerIP, int nPort, ref string result)
        {

            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint tempRemoteIP = new IPEndPoint(IPAddress.Parse(ServerIP), nPort);
                EndPoint epTemp = (EndPoint)tempRemoteIP;
                socket.Connect(epTemp);
                return socket;
            }
            catch (SocketException e) { result = e.ToString(); }
            catch (ArgumentOutOfRangeException e) { result = e.ToString(); }
            catch (ArgumentNullException e) { result = e.ToString(); }
            catch (ObjectDisposedException e) { result = e.ToString(); }
            catch (InvalidOperationException e) { result = e.ToString(); }
            catch (SecurityException e) { result = e.ToString(); }
            catch (Exception e) { result = e.ToString(); }
            return null;

        }

        public static uint Send(Socket client, Byte[] buff, uint nLen, SocketFlags flags = SocketFlags.None)
        {
            try
            {
                // Byte[] bytesSent = Encoding.ASCII.GetBytes(buff);
                return (uint)client.Send(buff, (int)nLen, flags);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
                //LogModule.ErrorLog(e.ToString());
            }
            return 0xFFFFFFFF;
        }
        public static void Close(Socket ClientSocket)
        {
            try
            {
                if (ClientSocket.Connected)
                {
                    ClientSocket.Shutdown(SocketShutdown.Both);
                }
            }
            catch (SocketException e)
            {
            }
            try
            {
                ClientSocket.Close();
            }
            catch (SocketException e)
            {
            }
        }
        public static uint Recv(Socket client, Byte[] buff, uint nLen, uint flags = 0)
        {

            try
            {

                uint bytes = 0;

                bytes = (uint)client.Receive(buff, (int)nLen, (SocketFlags)flags);
                // buff += Encoding.ASCII.GetString(bytesReceived, 0, bytes);

                return bytes;
            }
            catch (SocketException e)
            {
            }
            return 0xFFFFFFFF;
        }

        public static uint available(Socket client)
        {
            return (uint)client.Available;
        }
    }
}
