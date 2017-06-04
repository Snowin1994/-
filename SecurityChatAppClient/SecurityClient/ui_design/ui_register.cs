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
    public partial class ui_register : Form
    {
        public ui_register()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ui_register_FormClosing(object sender, FormClosingEventArgs e)
        {
            ui_login.GetInstance().Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(check_input())
            {
                string register_info = "Register:" +
                    tbx_username +
                    tbx_nickname +
                    tbx_pw +
                    tbx_username;
                ui_login.GetInstance().ChatClient.Send(register_info);
            }
        }

        private bool check_input()
        {
            if(tbx_username.Text != "" &&
                tbx_nickname.Text != "" &&
                tbx_pw.Text != "" &&
                tbx_pw_confirm.Text != "")
            {
                if(tbx_pw.Text != tbx_pw_confirm.Text)
                {
                    MessageBox.Show("两次输入的密码不相同！");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("输入不能为空！");
                return false;
            }
        }
    }
}
