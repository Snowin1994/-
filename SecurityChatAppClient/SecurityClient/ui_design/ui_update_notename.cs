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
    public partial class ui_update_notename : Form
    {
        private static ui_update_notename instance;
        private User user;
        private Friend friend;

        private ui_update_notename()
        {
            InitializeComponent();
        }
        private ui_update_notename(User _user, Friend _friend)
        {
            InitializeComponent();

            user = _user;
            friend = _friend;
        }

        public static ui_update_notename GetInstance(User _user, Friend _friend)
        {
            if(instance == null)
            {
                instance = new ui_update_notename(_user, _friend);
            }

            return instance;
        }

        private void ui_update_notename_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string data = "UpdateNote:"
                + user.Username + ","
                + friend.Username + ","
                + tbx_notename.Text;
            ui_login.GetInstance().ChatClient.Send(data);

            //foreach (Friend fri in ui_main_panel.GetInstance(user).friends_list)
            //{
            //    if (fri.Notename == friend.Notename)
            //    {
            //        fri.Notename = tbx_notename.Text;
            //    }
            //}
            //ui_main_panel.GetInstance(user).lsb_friends.Items.Remove(friend.Notename);
            //ui_main_panel.GetInstance(user).lsb_friends.Items.Add(tbx_notename.Text);


            this.Close();
        }

        private void ui_update_notename_Load(object sender, EventArgs e)
        {

        }
    }
}
