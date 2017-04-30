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
    public partial class ui_main_panel : Form
    {
        private static ui_main_panel instance;

        private ui_main_panel()
        {
            InitializeComponent();
        }

        public static ui_main_panel GetInstance()
        {
            if(instance == null)
            {
                instance = new ui_main_panel();
            }

            return instance;
        }

        private void ui_main_panel_Load(object sender, EventArgs e)
        {
            // 测试数据
            lsb_friends.Items.Add("张三");
            lsb_friends.Items.Add("李四");
            lsb_friends.Items.Add("王五");
            lsb_friends.Items.Add("赵柳");
            lsb_friends.Items.Add("飞龙");
            lsb_friends.Items.Add("小白");
        }

        private void tmenu_item_send_msg_Click(object sender, EventArgs e)
        {
            string str_user_name = lsb_friends.SelectedItem.ToString();

            ui_chat form_chat_with = new ui_chat(str_user_name);
            form_chat_with.Show();
        }

        private void tmenu_item_update_note_Click(object sender, EventArgs e)
        {
            ui_update_notename.GetInstance().Show();
        }

        private void pbx_user_icon_Click(object sender, EventArgs e)
        {
            ui_user_info.GetInstance().Show();
        }

        private void pbx_search_friends_Click(object sender, EventArgs e)
        {
            ui_search_friends.GetInstance().Show();
        }

        private void tmenu_update_password_Click(object sender, EventArgs e)
        {
            ui_update_password.GetInstance().Show();
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

    }
}
