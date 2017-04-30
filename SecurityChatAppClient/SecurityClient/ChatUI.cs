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
using SecurityClient.ui_design;

namespace SecurityClient
{
    public partial class ChatUI : Form
    {
        /// <summary>
        /// 线程 接受发送过来的数据
        /// </summary>
        private Thread thread_ReceiveSpace;

        public delegate void ShowTest(string msg_string, System.Windows.Forms.Control control);
        public ShowTest show_test;
        public static ChatUI ui_temp;

        public ChatUI()
        {
            InitializeComponent();
        }

        private void ChatUI_Load(object sender, EventArgs e)
        {
            // test other ui
            // new ui_login().Show();

            ui_temp = this;
            show_test = new ShowTest(set_test);
        }

        private void set_test(string msg_string, System.Windows.Forms.Control control)
        {
            control.Text += msg_string + System.Environment.NewLine + System.Environment.NewLine;
        }

        private void btnConnectClient_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnConnectClient.Text == "Connect")
                {
                    // string host = Client.Default.IP;
                    string host = "120.24.161.40";
                    int port = 2017;
                    IPAddress ip = IPAddress.Parse(host);
                    IPEndPoint ipEnd = new IPEndPoint(ip, port);
                    BeginReceive.sock_connect.Connect(ipEnd);
                    thread_ReceiveSpace = new Thread(() =>
                    {
                        BeginReceive.sock_connect.BeginReceive(
                            BeginReceive.b_data_buffer,                     //数据缓冲池
                            0,
                            BeginReceive.b_data_buffer.Length,
                            SocketFlags.None,
                            new AsyncCallback(BeginReceive.ReceiveMessage),
                            BeginReceive.sock_connect
                            );
                    });
                    thread_ReceiveSpace.IsBackground = true;
                    thread_ReceiveSpace.Start();

                    btnConnectClient.Text = "Disconnect";
                }
                else
                {
                    BeginReceive.sock_connect.Dispose();

                    if (thread_ReceiveSpace.IsAlive)
                    {
                        thread_ReceiveSpace.Abort();
                    }

                    BeginReceive.sock_connect = new Socket(
                        AddressFamily.InterNetwork, 
                        SocketType.Stream, 
                        ProtocolType.Tcp
                        );
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
            tbxSendMsg.Text = "";
        }

        private void SendAnyMsg(string source)
        {
            try
            {
                byte[] byte_Msg = Encoding.UTF8.GetBytes(source + "\r\n");

                BeginReceive.sock_connect.BeginSend(byte_Msg, 0, byte_Msg.Length, SocketFlags.None, null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
