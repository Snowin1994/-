using SecurityClient.Command;
using SecurityClient.ui_design;
using SecurityClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecurityClient
{
    public class SuperClient
    {
        /// <summary>
        /// 数据缓冲区大小
        /// </summary>
        private const int BUFFER_LEN = 10000;

        /// <summary>
        /// 客户端 socket 套接字实例化
        /// </summary>
        private Socket socket_connect;

        /// <summary>
        /// 数据缓冲区
        /// </summary>
        private byte[] b_data_buffer;

        /// <summary>
        /// 客户端接受数据的线程
        /// </summary>
        private Thread thread_receive_client;

        /// <summary>
        /// 数据读取起始位置 当前默认值为0
        /// </summary>
        private const int START_POS = 0;

        /// <summary>
        /// 服务器ip地址
        /// </summary>
        private readonly string STR_HOST = "127.0.0.1";
        // private readonly string STR_HOST = "120.24.161.40";

        private readonly int I_PORT = 2017;

        //private 

        private ThreadMessage thread_sender;

        public SuperClient()
        {
            b_data_buffer = new byte[BUFFER_LEN];
            socket_connect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            thread_sender = new ThreadMessage();
        }

        public bool Start(string host, int port)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(host);
                IPEndPoint ip_port = new IPEndPoint(ip, port);
                socket_connect.Connect(ip_port);
                thread_receive_client = new Thread(() =>
                {
                    socket_connect.BeginReceive(
                        b_data_buffer,
                        START_POS,
                        b_data_buffer.Length,
                        SocketFlags.None,
                        new AsyncCallback(ReceiveMessage),
                        socket_connect
                        );
                });
                thread_receive_client.IsBackground = true;
                thread_receive_client.Start();

                return true;
            }
            catch(Exception ex)
            {
                // 异常处理
                // 日志记录
                Stop();

                return false;
            }
        }

        public bool Start()
        {
            try
            {
                IPAddress ip = IPAddress.Parse(STR_HOST);
                IPEndPoint ip_port = new IPEndPoint(ip, I_PORT);
                socket_connect.Connect(ip_port);
                thread_receive_client = new Thread(() =>
                {
                    socket_connect.BeginReceive(
                        b_data_buffer,
                        START_POS,
                        b_data_buffer.Length,
                        SocketFlags.None,
                        new AsyncCallback(ReceiveMessage),
                        socket_connect
                        );
                });
                thread_receive_client.IsBackground = true;
                thread_receive_client.Start();

                return true;
            }
            catch (Exception ex)
            {
                // 异常处理
                // 日志记录
                Stop();

                return false;
            }
        }

        public bool Stop()
        {
            try
            {
                // 设置socket是否重用参数，默认true
                bool is_reuse = true;

                socket_connect.Disconnect(is_reuse);
                if (thread_receive_client.IsAlive)
                {
                    thread_receive_client.Abort();
                }

                return true;
            }
            catch (Exception ex)
            {
                // 异常处理
                // 日志记录

                return false;
            }
        }

        public void ReceiveMessage(IAsyncResult async_result)
        {
            try
            {
                var socket_con_get = async_result.AsyncState as Socket;
                

                var i_data_length = socket_con_get.EndReceive(async_result);
                var string_data = Encoding.UTF8.GetString(b_data_buffer, 0, i_data_length);

                // #####################################################
                // 线程通信 消息分发
                ChatReceiveFilter receive_filter = new ChatReceiveFilter();
                int rest = 0;
                ChatRequestInfo request_info = receive_filter.Filter(b_data_buffer, 0, i_data_length, false, out rest);

                ICommand command = null;
                if(request_info != null)
                {
                    switch(request_info.Key)
                    {
                        case "Login" : command = new Login(); break;
                        case "FriendList" : command = new FriendList(); break;
                        case "ReceiveMsg": command = new ReceiveMsg(); break;
                        case "UpdatePw": command = new UpdatePw(); break;
                        case "SearchFriend": command = new SearchFriend(); break;


                    }
                }

                if(command != null)
                {
                    command.ExecuteCommand(request_info.Body);
                }
                // #####################################################

                socket_connect.BeginReceive(b_data_buffer,
                    START_POS,
                    b_data_buffer.Length,
                    SocketFlags.None,
                    new AsyncCallback(ReceiveMessage),
                    socket_connect);
            }
            catch(Exception ex)
            {
                // 异常处理
            }
        }

        public bool Send(string source)
        {
            try
            {
                // *************************
                string str_head = "snowhead";
                string str_tail = "snowtail";
                // *************************

                byte[] byte_message = Encoding.UTF8.GetBytes(str_head + source + str_tail);
                socket_connect.BeginSend(byte_message, 0, byte_message.Length, SocketFlags.None, null, null);

                return true;
            }
            catch (Exception ex)
            {
                // 异常处理
                // 记录日志

                return false;
            }
        }
    }
}
