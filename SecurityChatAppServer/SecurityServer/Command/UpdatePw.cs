using SuperSocket.SocketBase.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServer.Command
{
    public class UpdatePw : CommandBase<ChatSession, ChatRequestInfo>
    {
        public override void ExecuteCommand(ChatSession session, ChatRequestInfo requestInfo)
        {
            string source = requestInfo.Body;
            int pos_1 = source.IndexOf(session.SPLITER);
            int pos_2 = source.IndexOf(session.SPLITER, pos_1 + 1);

            // 顺序：用户名、旧密码、新密码
            string username = source.Substring(0, pos_1);
            string password = source.Substring(pos_1 + 1, pos_2 - pos_1 - session.SPLITER.Length);
            string new_password = source.Substring(pos_2 + session.SPLITER.Length);

            bool result = ChatServer.Data_Operate.UpdatePw(username, password, new_password);

            string str_result = null;
            if(result)
            {
                str_result = "success";
            }
            else
            {
                str_result = "failure";
            }

            session.Send("UpdatePw:" + str_result);
        }
    }
}
