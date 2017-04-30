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

namespace SecurityClient.ui_design
{
    public partial class ui_login : Form
    {
        private static ui_login instance;

        /// <summary>
        /// 客户端实例
        /// </summary>
        private SuperClient chat_client;

        /// <summary>
        /// 接受服务器发送的数据
        /// </summary>
        private Thread thread_receive_data;

        private ui_login()
        {
            InitializeComponent();
        }

        public SuperClient ChatClient
        {
            get { return chat_client; }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            ui_main_panel.GetInstance().Show();
        }

        public static ui_login GetInstance()
        {
            if(instance == null)
            {
                instance = new ui_login();
            }

            return instance;
        }

        private void ui_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
            chat_client.Stop();

            //BeginReceive.sock_connect.Dispose();
            //if(thread_receive_data != null && thread_receive_data.IsAlive)
            //{
            //    thread_receive_data.Abort();
            //}
        }

        private void ui_login_Load(object sender, EventArgs e)
        {
            // string string_host = "120.24.161.40";
            string string_host = "127.0.0.1";
            int i_port = 2017;
            chat_client = new SuperClient();

            chat_client.Start(string_host, i_port);
        }
    }
}
