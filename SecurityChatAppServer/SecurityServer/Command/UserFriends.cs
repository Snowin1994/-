using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Command;

namespace SecurityServer.Command
{
    public class UserFriends : CommandBase<ChatSession, ChatRequestInfo>
    {
        public override void ExecuteCommand(ChatSession session, ChatRequestInfo requestInfo)
        {
            string username = requestInfo.Body;

            // 数据库查询好友列表，并返回好友信息
        }
    }
}
