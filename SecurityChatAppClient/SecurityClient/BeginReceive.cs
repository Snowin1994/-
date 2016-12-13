using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SecurityClient
{
    public static class BeginReceive
    {
        public static Socket connect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建Socket
        
        // public static Form1 form;

        public static byte[] dataBuffer = new byte[10000];
        public static void ReceiveMessage(IAsyncResult ar)
        {
            try
            {
                var socket = ar.AsyncState as Socket;
                var dataLength = socket.EndReceive(ar);

                //form.tbx_ReceiveMsg.Text += dataBuffer.ToString();
                //socket.BeginReceive(InitializeSocket.buffer, 0, InitializeSocket.buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveMessage), socket);
                //connect.BeginReceive(
                //    dataBuffer,                     //数据缓冲池
                //    0,
                //    dataBuffer.Length,
                //    SocketFlags.None,
                //    new AsyncCallback(ReceiveMessage),
                //    socket
                //    );
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}
