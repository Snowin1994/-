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

        private ui_user_info()
        {
            InitializeComponent();
        }

        public static ui_user_info GetInstance()
        {
            if(instance == null)
            {
                instance = new ui_user_info();
            }

            return instance;
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            // 保存数据

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ui_user_info_Load(object sender, EventArgs e)
        {

        }

        private void ui_user_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
