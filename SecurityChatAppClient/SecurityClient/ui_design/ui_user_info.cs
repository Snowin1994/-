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
    public partial class ui_user_info : Form
    {
        private static ui_user_info instance;
        private User user;

        private ui_user_info()
        {
            InitializeComponent();
        }
        private ui_user_info(User _user)
        {
            InitializeComponent();

            user = _user;
        }

        public static ui_user_info GetInstance(User _user)
        {
            if(instance == null)
            {
                instance = new ui_user_info(_user);
            }

            return instance;
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            // 保存数据
            string data = "UpdateUser:"
                + user.Username + "," 
                + tbx_nickname.Text + "," 
                + tbx_signature.Text;
            ui_login.GetInstance().ChatClient.Send(data);

            ui_main_panel.GetInstance(user).lbl_nickname.Text = tbx_nickname.Text;
            ui_main_panel.GetInstance(user).tbx_signature.Text = tbx_signature.Text;

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ui_user_info_Load(object sender, EventArgs e)
        {
            tbx_nickname.Text = user.Nickname;
            tbx_signature.Text = user.Signature;
        }

        private void ui_user_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
