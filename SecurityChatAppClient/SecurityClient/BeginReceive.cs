using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SecurityClient
{
    public static class BeginReceive
    {
        public static Socket sock_connect = new Socket(
            AddressFamily.InterNetwork, 
            SocketType.Stream, 
            ProtocolType.Tcp
            );//创建Socket
        
        // public static Form1 form;

        public static byte[] b_data_buffer = new byte[10000];

        public static void ReceiveMessage(IAsyncResult ar)
        {
            try
            {
                var socket = ar.AsyncState as Socket;
                var dataLength = socket.EndReceive(ar);

                var source = Encoding.UTF8.GetString(b_data_buffer, 0, dataLength);
                ChatUI.ui_temp.tbxRcvMsg.Invoke(
                    ChatUI.ui_temp.show_test,
                    new Object[] { source, ChatUI.ui_temp.tbxRcvMsg }
                    );

                //form.tbx_ReceiveMsg.Text += dataBuffer.ToString();
                //socket.BeginReceive(dataBuffer, 0, dataLength, SocketFlags.None, new AsyncCallback(ReceiveMessage), socket);
                sock_connect.BeginReceive(
                    b_data_buffer,                     //数据缓冲池
                    0,
                    b_data_buffer.Length,
                    SocketFlags.None,
                    new AsyncCallback(ReceiveMessage),
                    socket
                    );
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}
