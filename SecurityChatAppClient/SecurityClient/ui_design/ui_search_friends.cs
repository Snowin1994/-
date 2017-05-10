using Newtonsoft.Json;
using System;
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
    public partial class ui_search_friends : Form
    {
        private static ui_search_friends instance;
        private User friend_user;

        public delegate void ShowResult(string user_json);
        public ShowResult show_result;

        private ui_search_friends()
        {
            InitializeComponent();
        }

        public static ui_search_friends GetInstance()
        {
            if(instance == null)
            {
                instance = new ui_search_friends();
            }

            return instance;
        }

        private void SetResult(string user_json)
        {
            friend_user = JsonConvert.DeserializeObject<User>(user_json);

            tbx_username.Text = friend_user.Username;
            tbx_nickname.Text = friend_user.Nickname;
            tbx_signature.Text = friend_user.Signature;
        }

        private void ui_search_friends_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void ui_search_friends_Load(object sender, EventArgs e)
        {
            show_result = new ShowResult(SetResult);
        }

        private void btn_search_friend_Click(object sender, EventArgs e)
        {
            if(tbx_friend_username.Text == "")
            {
                MessageBox.Show("输入不能为空！");
            }
            else
            {
                string cmd = "SearchFriend:" + tbx_friend_username.Text;

                ui_login.GetInstance().ChatClient.Send(cmd);
            }
        }

        private void btn_add_friend_Click(object sender, EventArgs e)
        {
            foreach (Friend friend in ui_main_panel.GetInstance(new User()).friends_list)
            {
                if(friend.Username == friend_user.Username)
                {
                    MessageBox.Show("ta已经是你的好友啦！");

                    return;
                }
            }
            if (friend_user.Username != ui_main_panel.user.Username)
            {
                string cmd = "AddFriend:" + ui_main_panel.user.Username
                    + "," + friend_user.Username
                    + "," + friend_user.Nickname;
                ui_login.GetInstance().ChatClient.Send(cmd);

                MessageBox.Show("添加成功！");

                this.Close();
            }
            else
            {
                MessageBox.Show("你不可以添加你自己！");
            }
            
        }
    }
}
