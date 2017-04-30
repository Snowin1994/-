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

        private void ui_search_friends_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
