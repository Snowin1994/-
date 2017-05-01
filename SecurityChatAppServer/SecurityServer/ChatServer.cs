using MysqlConnection;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServer
{
    class ChatServer : AppServer<ChatSession, ChatRequestInfo>
    {
        private static MDO data_operate = new MDO();
        public ChatServer()
            : base(new ChatReceiveFilterFactory())
        {
            
        }

        public static MDO Data_Operate
        {
            get { return data_operate; }
            set { data_operate = value; }
        }

        protected override bool Setup(IRootConfig rootConfig, IServerConfig config)
        {
            return base.Setup(rootConfig, config);
        }

        protected override void OnStarted()
        {
            base.OnStarted();
        }

        protected override void OnStopped()
        {
            base.OnStopped();
        }
    }
}
