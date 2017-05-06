using SecurityClient.ui_design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityClient.Command
{
    class ReceiveMsg : ICommand
    {
        public void ExecuteCommand(string body)
        {
            const string SPLITER = ",";

            string source = body;
            int pos_1 = source.IndexOf(SPLITER);
            int pos_2 = source.IndexOf(SPLITER, pos_1 + 1);

            // data 顺序：发送者，消息类型，消息
            string sender = source.Substring(0, pos_1);
            string msg_type = source.Substring(pos_1 + 1, pos_2 - pos_1 - SPLITER.Length);
            string msg = source.Substring(pos_2 + SPLITER.Length);

            ui_chat form_sender = (ui_chat)ui_chat.tables_friends[sender];
            form_sender.Invoke(
                form_sender.show_text,
                new Object[] { msg, msg_type, form_sender.rtbx_receive_msg }
                );
        }
    }
}
