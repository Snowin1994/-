using SuperSocket.SocketBase.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServer.Command
{
    public class DeleteFriend : CommandBase<ChatSession, ChatRequestInfo>
    {
        public override void ExecuteCommand(ChatSession session, ChatRequestInfo requestInfo)
        {
            string source = requestInfo.Body;
            int pos = source.IndexOf(session.SPLITER);

            string username = source.Substring(0, pos);
            string friend_username = source.Substring(pos + session.SPLITER.Length);

            ChatServer.Data_Operate.DeleteFriend(username, friend_username);
        }
    }
}
