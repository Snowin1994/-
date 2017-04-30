using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityClient.ui_design
{
    public partial class ui_chat : Form
    {
        private const int FORM_WEIGHT_NOHISTORY = 516;
        private const int FORM_WEIGHT_HISTORY = 798;
        /// <summary>
        /// 保存已经打开的好友名称
        /// </summary>
        private static ArrayList alist_chatting_friends = new ArrayList();
        private const string STR_TITLE_BEFOR = "与";
        private const string STR_TITLE_AFTER = "聊天中...";

        private string str_friend_name;

        //////////////////
        // UI跨线程显示 //
        //////////////////

        public delegate void ShowText(string text, System.Windows.Forms.Control control);
        public ShowText show_text;
        public static ui_chat p_ui_chat;

        public ui_chat()
        {
            InitializeComponent();
        }

        public ui_chat(string name)
        {
            // 获取好友姓名
            str_friend_name = name;

            InitializeComponent();
        }

        private void SetMessage(string msg, System.Windows.Forms.Control control)
        {
            control.Text += msg + System.Environment.NewLine + System.Environment.NewLine ;
        }

        private void init_data(string str_name)
        {
            bool bl_exist = alist_chatting_friends.Contains(str_name);
            if (!bl_exist)
            {
                alist_chatting_friends.Add(str_name);
            }
        }

        private void ui_chat_Load(object sender, EventArgs e)
        {
            this.Text = STR_TITLE_BEFOR + str_friend_name + STR_TITLE_AFTER;
            this.Size = new Size(FORM_WEIGHT_NOHISTORY, this.Size.Height);
            p_ui_chat = this;
            // 给委托添加方法
            show_text = new ShowText(SetMessage);
        }

        private void btn_chat_history_Click(object sender, EventArgs e)
        {
            if (this.Size.Width == FORM_WEIGHT_NOHISTORY)
            {
                this.Size = new Size(FORM_WEIGHT_HISTORY, this.Size.Height);
            }
            else
            {
                this.Size = new Size(FORM_WEIGHT_NOHISTORY, this.Size.Height);
            }
        }

        private void btn_close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_send_msg_Click(object sender, EventArgs e)
        {
            ui_login.GetInstance().ChatClient.Send(tbx_send_msg.Text);

            // 刷新发送消息UI显示
            rtbx_receive_msg.Text += tbx_send_msg.Text + System.Environment.NewLine;
            tbx_send_msg.Text = "";
        }
    }
}
