using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Command;

namespace SecurityServer.Command
{
    public class Login : CommandBase<ChatSession, ChatRequestInfo>
    {
        public override void ExecuteCommand(ChatSession session, ChatRequestInfo requestInfo)
        {
            string source = requestInfo.Body;
            int pos = source.IndexOf(session.SPLITER);

            string username = source.Substring(0, pos);
            string password = source.Substring(pos + session.SPLITER.Length);

            // 查询数据库结果
            ExecuteResult result = ChatServer.Data_Operate.Login(username, password);
            session.Send("Login:" + result.ToString());

            if(result == ExecuteResult.Success)
            {
                session.Username = username;
            }
        }
    }
}
