using SecurityClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SecurityClient.ui_design
{
    public partial class ui_main_panel : Form
    {
        private static ui_main_panel instance;

        public static User user;
        public Friend[] friends_list;

        // 接受消息并分发到对应的好友窗体
        public delegate void Handout(string body);
        public Handout handout;


        //////////////////
        // UI跨线程显示 //
        //////////////////

        public delegate void ShowList(string text, System.Windows.Forms.ListBox lsb);
        public ShowList show_list;

        private ui_main_panel()
        {
            InitializeComponent();
        }

        private ui_main_panel(User _user)
        {
            InitializeComponent();

            user = _user;
        }

        public static ui_main_panel GetInstance(User _user)
        {
            if(instance == null)
            {
                instance = new ui_main_panel(_user);
            }

            return instance;
        }

        private void SetList(string friends, System.Windows.Forms.ListBox lsb)
        {
            friends_list = (Friend[])JsonConvert.DeserializeObject<Friend[]>(friends);
            lsb_friends.Items.Clear();
            foreach (Friend friend in friends_list)
            {
                lsb_friends.Items.Add(friend.Notename);
            }

        }

        private void SetForm(string body)
        {
            const string SPLITER = ",";

            string source = body;
            int pos_1 = source.IndexOf(SPLITER);
            int pos_2 = source.IndexOf(SPLITER, pos_1 + 1);

            // data 顺序：发送者，消息类型，消息
            string sender = source.Substring(0, pos_1);
            string msg_type = source.Substring(pos_1 + 1, pos_2 - pos_1 - SPLITER.Length);
            string msg = source.Substring(pos_2 + SPLITER.Length);

            ui_chat form_chat_with = null;
            foreach (Friend friend in friends_list)
            {
                if (friend.Username == sender)
                {
                    form_chat_with = ui_chat.GetInstance(friend.Username, friend.Notename);
                    form_chat_with.Show();

                    break;
                }
            }

            if (form_chat_with != null)
            {
                form_chat_with.Invoke(
                    form_chat_with.show_text,
                    new Object[] { msg, msg_type, form_chat_with.rtbx_receive_msg }
                    );
            }
            else
            {
                // 陌生人
            }
        }

        private void ui_main_panel_Load(object sender, EventArgs e)
        {
            // tips绑定
            tip_main_panel.SetToolTip(picBox_setting, "右键单击，展示工具箱");
            tip_main_panel.SetToolTip(picBox_user_icon, "单击修改个人信息");

            show_list = new ShowList(SetList);
            handout = new Handout(SetForm);
            
            // 设置用户昵称、签名
            this.lbl_nickname.Text = user.Nickname;
            this.tbx_signature.Text = user.Signature;

        }

        private void tmenu_item_send_msg_Click(object sender, EventArgs e)
        {
            try
            {
                string notename = lsb_friends.SelectedItem.ToString();
                foreach (Friend friend in friends_list)
                {
                    if (friend.Notename == notename)
                    {
                        ui_chat form_chat_with = ui_chat.GetInstance(friend.Username, friend.Notename);
                        form_chat_with.Show();
                        form_chat_with.Activate();

                        return;
                    }
                }

                throw new Exception("无此好友!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("未选中好友！");
            }

        }

        private void tmenu_item_update_note_Click(object sender, EventArgs e)
        {
            string notename = lsb_friends.SelectedItem.ToString();
            foreach (Friend friend in friends_list)
            {
                if (friend.Notename == notename)
                {
                    ui_update_notename.GetInstance(user, friend).Show();

                    return;
                }
            }

        }

        private void pbx_user_icon_Click(object sender, EventArgs e)
        {
            ui_user_info.GetInstance(user).Show();
        }

        private void pbx_search_friends_Click(object sender, EventArgs e)
        {
            ui_search_friends.GetInstance().Show();
        }

        private void tmenu_update_password_Click(object sender, EventArgs e)
        {
            ui_update_password.GetInstance(user).Show();
        }

        private void ui_main_panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;

            ui_login.GetInstance().Show();
        }

        private void lsb_friends_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lsb_friends.SelectedItem == null)
            {
                cmenus_friend_setting.Close();
            }
        }

        private void tmenu_switch_user_Click(object sender, EventArgs e)
        {
            this.Close();
            ui_login.GetInstance().Show();
        }

        private void ui_main_panel_Activated(object sender, EventArgs e)
        {
            // 请求好友列表
            ui_login.GetInstance().ChatClient.Send("FriendList:"
                + user.Username);
        }

        private void tmenu_item_delete_friend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除好友", "删除好友", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
            {
                string notename = lsb_friends.SelectedItem.ToString();
                foreach (Friend friend in friends_list)
                {
                    if (friend.Notename == notename)
                    {
                        ui_login.GetInstance().ChatClient.Send("DeleteFriend:"
                            + user.Username + "," + friend.Username);

                        break;
                    }
                }

                ui_login.GetInstance().ChatClient.Send("FriendList:"
                    + user.Username);
            }
        }

        private void lsb_friends_DoubleClick(object sender, EventArgs e)
        {
            tmenu_item_send_msg_Click(this, EventArgs.Empty);
        }

    }
}
