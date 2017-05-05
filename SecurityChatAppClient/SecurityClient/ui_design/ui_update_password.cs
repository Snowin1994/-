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
    public partial class ui_update_password : Form
    {
        private static ui_update_password instance;
        private User user;

        public delegate void SendMsg(string result);
        public SendMsg sender_msg;

        private ui_update_password()
        {
            InitializeComponent();
        }
        private ui_update_password(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        public static ui_update_password GetInstance(User _user)
        {
            if(instance == null)
            {
                instance = new ui_update_password(_user);
            }

            return instance;
        }

        private void SetUpdateResult(string result)
        {
            if(result == "success")
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("原密码错误");
            }
        }

        private void ui_update_password_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(tbx_new_pw.Text != tbx_new_re_pw.Text)
            {
                MessageBox.Show("两次输入不相同！");
                tbx_new_pw.Text = "";
                tbx_new_re_pw.Text = "";
            }
            else
            {
                ui_login.GetInstance().ChatClient.Send("UpdatePw:"
                    + user.Username + "," 
                    + tbx_old_pw.Text + ","
                    + tbx_new_pw.Text);
            }
        }

        private void ui_update_password_Load(object sender, EventArgs e)
        {
            sender_msg = new SendMsg(SetUpdateResult);
        }
    }
}
