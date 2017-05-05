using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Command;
using SecurityServer.DbOperation;
using Newtonsoft.Json;
using MysqlConnection;

namespace SecurityServer.Command
{
    public class Login : CommandBase<ChatSession, ChatRequestInfo>
    {
        public override void ExecuteCommand(ChatSession session, ChatRequestInfo requestInfo)
        {
            try
            {
                string source = requestInfo.Body;
                MDO.Log(source);
                int pos = source.IndexOf(session.SPLITER);

                string username = source.Substring(0, pos);
                string password = source.Substring(pos + session.SPLITER.Length);

                // 查询数据库结果
                User user = ChatServer.Data_Operate.Login(username, password);
                string user_json = JsonConvert.SerializeObject(user);

                session.Send("Login:" + user_json);

                if (user != null)
                {
                    session.Username = username;
                }
            }
            catch (Exception ex)
            {
                MDO.Log(ex.ToString());
            }
        }
    }
}
