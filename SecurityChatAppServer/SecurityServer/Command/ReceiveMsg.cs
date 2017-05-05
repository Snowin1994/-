using SuperSocket.SocketBase.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServer.Command
{
    public class ReceiveMsg : CommandBase<ChatSession, ChatRequestInfo>
    {
        public override void ExecuteCommand(ChatSession session, ChatRequestInfo requestInfo)
        {
            string source = requestInfo.Body;
            int pos_1 = source.IndexOf(session.SPLITER);
            int pos_2 = source.IndexOf(session.SPLITER,pos_1 + 1);

            // 顺序：接受者，消息类型，消息
            string receiver = source.Substring(0, pos_1);
            string msg_type = source.Substring(pos_1 + 1, pos_2 - pos_1 - session.SPLITER.Length);
            string msg = source.Substring(pos_2 + session.SPLITER.Length);

            // 存储聊天记录
            /***************/
            /***************/

            // 转发消息到接收方
            foreach (var user in session.AppServer.GetSessions(s => s.Username == receiver))
            {
                user.Send("ReceiveMsg:" 
                    + session.Username
                    + "," + msg_type
                    + "," + msg);
            }
        }
    }
}
