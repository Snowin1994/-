using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServer
{
    public class ChatSession : AppSession<ChatSession, ChatRequestInfo>
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private const string STR_HEAD = "snowhead";
        private const string STR_TAIL = "snowtail";
        public readonly string SPLITER = ",";

        protected override void OnSessionStarted()
        {

        }

        protected override void HandleUnknownRequest(ChatRequestInfo requestInfo)
        {
            this.Send("Unknow request");
        }

        protected override void HandleException(Exception e)
        {
            this.Send("Application error: {0}", e.Message);
        }

        protected override void OnSessionClosed(CloseReason reason)
        {
            base.OnSessionClosed(reason);
        }

        public override void Send(string message)
        {
            base.Send(STR_HEAD + message + STR_TAIL);
        }
    }
}
