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

        private ui_update_password()
        {
            InitializeComponent();
        }

        public static ui_update_password GetInstance()
        {
            if(instance == null)
            {
                instance = new ui_update_password();
            }

            return instance;
        }

        private void ui_update_password_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
