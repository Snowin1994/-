using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Command;
using SecurityServer.DbOperation;
using Newtonsoft.Json;

namespace SecurityServer.Command
{
    public class FriendList : CommandBase<ChatSession, ChatRequestInfo>
    {
        public override void ExecuteCommand(ChatSession session, ChatRequestInfo requestInfo)
        {
            string username = requestInfo.Body;

            Friend[] friends = ChatServer.Data_Operate.GetFriendList(username);
            string friends_json = JsonConvert.SerializeObject(friends);
            string message = "FriendList:" + friends_json;

            session.Send(message);
        }
    }
}
