using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityClient
{
    public partial class ChatUI : Form
    {
        /// <summary>
        /// 线程 接受发送过来的数据
        /// </summary>
        private Thread thread_ReceiveSpace;

        public ChatUI()
        {
            InitializeComponent();
        }

        private void btnConnectClient_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnConnectClient.Text == "Connect")
                {
                    string host = Client.Default.IP;
                    int port = Client.Default.Port;
                    IPAddress ip = IPAddress.Parse(host);
                    IPEndPoint ipEnd = new IPEndPoint(ip, port);
                    BeginReceive.connect.Connect(ipEnd);
                    thread_ReceiveSpace = new Thread(() =>
                    {
                        BeginReceive.connect.BeginReceive(
                            BeginReceive.dataBuffer,                     //数据缓冲池
                            0,
                            BeginReceive.dataBuffer.Length,
                            SocketFlags.None,
                            new AsyncCallback(BeginReceive.ReceiveMessage),
                            BeginReceive.connect
                            );
                    });
                    thread_ReceiveSpace.Start();

                    btnConnectClient.Text = "Disconnect";
                }
                else
                {
                    BeginReceive.connect.Dispose();

                    if (thread_ReceiveSpace.IsAlive)
                    {
                        thread_ReceiveSpace.Abort();
                    }

                    BeginReceive.connect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    btnConnectClient.Text = "Connect";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace); 
                MessageBox.Show(ex.ToString());
                // 在log生成异常记录
            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            string src = tbxSendMsg.Text;
            SendAnyMsg(src);
        }

        private void SendAnyMsg(string source)
        {
            try
            {
                byte[] byte_Msg = Encoding.ASCII.GetBytes(source);

                BeginReceive.connect.BeginSend(byte_Msg, 0, byte_Msg.Length, SocketFlags.None, null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
