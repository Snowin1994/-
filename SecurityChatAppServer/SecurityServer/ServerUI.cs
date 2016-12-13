using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityServer
{
    public partial class ServerUI : Form
    {
        private AppServer appServer;
        public ServerUI()
        {
            InitializeComponent();
        }

        private void ServerUI_Load(object sender, EventArgs e)
        {
            ServerInit();
        }

        private void ServerInit()
        {
            
        }

        private void btnConnectServer_Click(object sender, EventArgs e)
        {
            if(btnConnectServer.Text == "Connect")
            {
                appServer = new AppServer();
                int port = Common.StringToInt(tbxPort.Text);
                if (!appServer.Setup(port))
                {
                    ShowInfoToStatusBox("Failed to setup!");
                }
                if (!appServer.Start())
                {
                    ShowInfoToStatusBox("Failed to start!");
                }
                ShowInfoToStatusBox("Successed to start!");

                btnConnectServer.Text = "Disconnect";
            }
            else
            {
                appServer.Stop();
                appServer = null;
                ShowInfoToStatusBox("Successed to stop!");

                btnConnectServer.Text = "Connect";
            }
        }

        private void ShowInfoToStatusBox(String info)
        {
            tbxStatusBox.Text += info + System.Environment.NewLine;
        }
    }
}
