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
        protected override void OnSessionStarted()
        {
            //this.Send(
            //    "Welcome to Snowin's world!" + 
            //    System.Environment.NewLine + 
            //    DateTime.Now.ToString()
            //    );
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
    }
}
