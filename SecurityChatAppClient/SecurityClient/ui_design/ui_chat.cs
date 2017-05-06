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
        public static Hashtable tables_friends = new Hashtable();

        // private static ArrayList alist_chatting_friends = new ArrayList();
        private const string STR_TITLE_BEFOR = "与";
        private const string STR_TITLE_AFTER = "聊天中...";

        private string str_username;
        private string str_friend_notename;

        //////////////////
        // UI跨线程显示 //
        //////////////////

        public delegate void ShowText(string text, string type, System.Windows.Forms.RichTextBox control);
        public ShowText show_text;

        private ui_chat()
        {
            InitializeComponent();
        }

        private ui_chat(string username, string notename)
        {
            // 获取好友姓名
            str_username = username;
            str_friend_notename = notename;

            InitializeComponent();
        }

        public static ui_chat GetInstance(string username, string notename)
        {
            if(!tables_friends.Contains(username))
            {
                tables_friends.Add(username, new ui_chat(username, notename));

            }

            return (ui_chat)tables_friends[username];
        }

        private void SetMessage(string msg, string type, System.Windows.Forms.RichTextBox control)
        {
            string source = str_friend_notename + "  "
                + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + System.Environment.NewLine
                + "  " + msg + System.Environment.NewLine;
            if(type == "common")
            {
                UpdateShowForm(source);
            }
            else
            {

            }
        }

        private void ui_chat_Load(object sender, EventArgs e)
        {
            this.Text = STR_TITLE_BEFOR + str_friend_notename + STR_TITLE_AFTER;
            this.Size = new Size(FORM_WEIGHT_NOHISTORY, this.Size.Height);
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

        private void UpdateShowForm(string msg)
        {
            rtbx_receive_msg.Focus();
            rtbx_receive_msg.Select(rtbx_receive_msg.TextLength, 0);
            rtbx_receive_msg.ScrollToCaret();
            rtbx_receive_msg.AppendText(msg);
        }

        private void btn_send_msg_Click(object sender, EventArgs e)
        {
            if (inputCheck(tbx_send_msg.Text))
            {
                string msg_type = "common";
                if(ckBox_moment.Checked == true)
                {
                    msg_type = "moment";
                }
                ui_login.GetInstance().ChatClient.Send("ReceiveMsg:"
                    + str_username
                    + msg_type
                    + tbx_send_msg.Text);

                // 刷新发送消息UI显示
                UpdateShowForm(this.SetFormat(tbx_send_msg.Text));
                tbx_send_msg.Text = "";
            }
            else
            {
                MessageBox.Show("发送内容不能为空，请重新输入！");
            }
        }

        /// <summary>
        /// 检查输入是否合法
        /// </summary>
        /// <param name="source">输入</param>
        /// <returns>输入合法返回true</returns>
        private bool inputCheck(string source)
        {
            if(source == "" || source == System.Environment.NewLine)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private string SetFormat(string source)
        {
            string result = ui_main_panel.user.Nickname + "  " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + System.Environment.NewLine
                + "  " + source + System.Environment.NewLine;

            return result;
        }

        private void ui_chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            tables_friends.Remove(str_username);
        }

        private void tbx_send_msg_TextChanged(object sender, EventArgs e)
        {
            if(tbx_send_msg.Text == System.Environment.NewLine)
            {
                tbx_send_msg.Text = "";
                tbx_send_msg.Focus();
            }
        }

        private void tbx_send_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_send_msg_Click(this, EventArgs.Empty);
            }
        }
    }
}
