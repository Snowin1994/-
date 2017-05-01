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
            int pos_1 = source.IndexOf("");
            int pos_2 = source.IndexOf(SPLITER, pos_1 + 1);

            // 顺序：接受者，消息类型，消息
            string receiver = source.Substring(0, pos_1);
            string msg_type = source.Substring(pos_1 + 1, pos_2 - pos_1 - SPLITER.Length);
            string msg = source.Substring(pos_2 + SPLITER.Length);

            ui_chat.p_ui_chat.Invoke(
                ui_chat.p_ui_chat.show_text,
                new Object[] { msg, ui_chat.p_ui_chat.rtbx_receive_msg }
                );
        }
    }
}
