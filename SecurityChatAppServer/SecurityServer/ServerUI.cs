using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
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
        private ChatServer appServer;
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
            btnConnectServer.PerformClick();
        }

        private void btnConnectServer_Click(object sender, EventArgs e)
        {
            if(btnConnectServer.Text == "Connect")
            {
                appServer = new ChatServer();
                // int port = 
                var serverConfig = new ServerConfig
                {
                    Port = Common.StringToInt(tbxPort.Text),
                    TextEncoding = "UTF-8",
                };
                if (!appServer.Setup(serverConfig))
                {
                    ShowInfoToStatusBox("Failed to setup!");
                    return;
                }
                if (!appServer.Start())
                {
                    ShowInfoToStatusBox("Failed to start!");
                    return;
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
