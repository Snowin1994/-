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
            const string SPLITER = ",";

            string source = requestInfo.Body;
            int pos = source.IndexOf(SPLITER);

            string username = source.Substring(0, pos);
            string password = source.Substring(pos + SPLITER.Length);

            // 查询数据库结果
            if(username == "snowin")
            {
                session.Send("Login:success");
            }
            else
            {
                session.Send("Login:fail");
            }
        }
    }
}
