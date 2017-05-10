using Newtonsoft.Json;
using SecurityServer.DbOperation;
using SuperSocket.SocketBase.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServer.Command
{
    public class SearchFriend : CommandBase<ChatSession, ChatRequestInfo>
    {
        public override void ExecuteCommand(ChatSession session, ChatRequestInfo requestInfo)
        {
            string username = requestInfo.Body;

            User user = ChatServer.Data_Operate.SearchFriend(username);
            string user_json = JsonConvert.SerializeObject(user);

            session.Send("SearchFriend:" + user_json);
        }
    }
}
