﻿using SecurityClient;
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
using Newtonsoft.Json;

namespace SecurityClient.ui_design
{
    public partial class ui_login : Form
    {
        private static ui_login instance;

        /// <summary>
        /// 客户端实例
        /// </summary>
        private SuperClient chat_client;

        private User user;

        ////////////////////
        // 跨线程数据显示 //
        ////////////////////

        public delegate void SendMsg(string result);
        public SendMsg sender_msg;

        private ui_login()
        {
            InitializeComponent();
        }

        private void SetLoginRsult(string user_json)
        {
            user = JsonConvert.DeserializeObject<User>(user_json);

            if(user != null)
            {
                this.Hide();
                ui_main_panel.GetInstance(user).Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

        public SuperClient ChatClient
        {
            get { return chat_client; }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string cmd = "Login:" + tbx_username.Text + "," + tbx_password.Text;
            chat_client.Send(cmd);
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
            try
            {
                chat_client.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                instance = null;
                System.Environment.Exit(0);
            }
        }

        private void ui_login_Load(object sender, EventArgs e)
        {
            try
            {
                // string string_host = "120.24.161.40";
                // string string_host = "127.0.0.1";
                // int i_port = 2017;

                chat_client = new SuperClient();

                if (!chat_client.Start())
                {
                    throw new Exception("请检查网络连接");
                }
                // 给线程间通信的委托添加方法
                sender_msg = new SendMsg(SetLoginRsult);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                System.Environment.Exit(0);
            }
        }

        private void ui_login_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btn_login_Click(this, EventArgs.Empty); break;
            }
        }

        private void linkLbl_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ui_register().Show();
        }
    }
}
