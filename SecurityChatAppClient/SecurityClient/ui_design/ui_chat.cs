using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private Hashtable tables_moment_msg;

        // private static ArrayList alist_chatting_friends = new ArrayList();
        private const string STR_TITLE_BEFOR = "与";
        private const string STR_TITLE_AFTER = "聊天中...";
        private const string STR_NEWLINE = "\n";
        private const string STR_MOMENT_Shown = "点击查看";
        private const string STR_READ_FINISH = STR_TAB + "阅读完成";
        private const string STR_TAB = "  ";

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
            string source = null;
            if (type == "common")
            {
                source = str_friend_notename + "  "
                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + STR_NEWLINE
                    + STR_TAB + msg + STR_NEWLINE;
                rtbx_receive_msg.AppendText(source);
            }
            else
            {
                source = str_friend_notename + "  "
                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + STR_NEWLINE
                    + STR_TAB + STR_MOMENT_Shown + STR_NEWLINE;
                rtbx_receive_msg.AppendText(source);


                rtbx_receive_msg.Select(rtbx_receive_msg.TextLength - source.Length, source.Length);
                rtbx_receive_msg.SelectionColor = Color.Red;

                var select_start = rtbx_receive_msg.SelectionStart;
                var select_line = rtbx_receive_msg.GetLineFromCharIndex(select_start);
                tables_moment_msg.Add(select_line, msg);
            }

            rtbx_receive_msg.Focus();
            rtbx_receive_msg.Select(rtbx_receive_msg.TextLength, 0);
            rtbx_receive_msg.ScrollToCaret();
            tbx_send_msg.Focus();
        }

        private void ui_chat_Load(object sender, EventArgs e)
        {
            this.Text = STR_TITLE_BEFOR + str_friend_notename + STR_TITLE_AFTER;
            this.Size = new Size(FORM_WEIGHT_NOHISTORY, this.Size.Height);
            // 给委托添加方法
            show_text = new ShowText(SetMessage);

            tables_moment_msg = new Hashtable();
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

        /// <summary>
        /// 将消息显示到richTextBox上，再将其进度条滑到最后一行
        /// </summary>
        /// <param name="msg"></param>
        private void UpdateShowForm(string msg, string type)
        {
            rtbx_receive_msg.Focus();
            rtbx_receive_msg.Select(rtbx_receive_msg.TextLength, 0);
            rtbx_receive_msg.ScrollToCaret();
            rtbx_receive_msg.AppendText(msg);
            if(type == "moment")
            {
                rtbx_receive_msg.Select(rtbx_receive_msg.TextLength - msg.Length, msg.Length);
                rtbx_receive_msg.SelectionColor = Color.Red;
            }
            tbx_send_msg.Focus();
        }

        private void btn_send_msg_Click(object sender, EventArgs e)
        {
            if (inputCheck(tbx_send_msg.Text))
            {
                // 消息类型
                string msg_type = null;
                // 要显示到richTextBox上的格式化后的数据
                string msg_Format = this.SetFormat(tbx_send_msg.Text, ckBox_moment.Checked, out msg_type);

                /**********************************/

                rtbx_receive_msg.Focus();
                rtbx_receive_msg.Select(rtbx_receive_msg.TextLength, 0);
                rtbx_receive_msg.ScrollToCaret();
                rtbx_receive_msg.AppendText(msg_Format);
                if (msg_type == "moment")
                {
                    rtbx_receive_msg.Select(rtbx_receive_msg.TextLength - msg_Format.Length, msg_Format.Length);
                    rtbx_receive_msg.SelectionColor = Color.Red;
                }
                tbx_send_msg.Focus();

                /**********************************/


                // UpdateShowForm(msg_Format, msg_type);

                ui_login.GetInstance().ChatClient.Send("ReceiveMsg:"
                    + str_username + ","
                    + msg_type + ","
                    + tbx_send_msg.Text);

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
            if(source == "" || source == STR_NEWLINE)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 增加发送者、时间戳、格式控制
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private string SetFormat(string source, bool b_type, out string type)
        {
            string result = null;

            if (b_type)
            {
                type = "moment";
                result = ui_main_panel.user.Nickname + "  " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + STR_NEWLINE
                    + STR_TAB + "阅后即焚" + STR_NEWLINE;
            }
            else
            {
                type = "common";
                result = ui_main_panel.user.Nickname + "  " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + STR_NEWLINE
                    + STR_TAB + source + STR_NEWLINE;
            }

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
            else if(e.Modifiers == Keys.Control && e.KeyCode == Keys.Y)
            {
                if(ckBox_moment.Checked == true)
                {
                    ckBox_moment.Checked = false;
                }
                else
                {
                    ckBox_moment.Checked = true;
                }
            }
        }

        private void rtbx_receive_msg_Click(object sender, EventArgs e)
        {
            var select_start = rtbx_receive_msg.SelectionStart;
            var select_line = rtbx_receive_msg.GetLineFromCharIndex(select_start);
            
            // rtbx_receive_msg.Select(select_start, 0);
            var select_len = rtbx_receive_msg.Lines[select_line].Length;

            var line_start = rtbx_receive_msg.GetFirstCharIndexFromLine(select_line);
            rtbx_receive_msg.Select(line_start, select_len);
            // 判断是否是阅焚消息
            if(isMoment(rtbx_receive_msg.SelectedText))
            {
                rtbx_receive_msg.SelectionColor = Color.Green;
                string moment_msg = (string)tables_moment_msg[select_line - 1];
                rtbx_receive_msg.SelectedText = STR_TAB + moment_msg;
                rtbx_receive_msg.Update();

                // 休眠时间
                Thread.Sleep(sleepTime(moment_msg));

                rtbx_receive_msg.Select(line_start, moment_msg.Length + STR_TAB.Length);
                rtbx_receive_msg.SelectedText = STR_READ_FINISH;

                var char_tail = rtbx_receive_msg.Text[rtbx_receive_msg.Text.Length - 1];
                if (char_tail != '\n')
                {
                    rtbx_receive_msg.AppendText("\n");
                }
                

            }            
        }

        /// <summary>
        /// 文件显示时间的控制算法 1s/10字
        /// </summary>
        /// <param name="source">要输出的字符</param>
        /// <returns>文字显示的时间</returns>
        private int sleepTime(string source)
        {
            int FACTOR = 1000;
            var second = source.Length / 10 + 1;

            return second * FACTOR;
        }

        private bool isMoment(string source)
        {
            if (rtbx_receive_msg.SelectionColor == Color.Red && source == STR_TAB + STR_MOMENT_Shown)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
