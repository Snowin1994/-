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
            ui_main_panel form_main = ui_main_panel.GetInstance(new User());
            form_main.Invoke(
                form_main.handout,
                new Object[] { body}
                );

            //ui_chat form_chat_with = null;
            //foreach (Friend friend in ui_main_panel.GetInstance(new User()).friends_list)
            //{
            //    if (friend.Username == sender)
            //    {
            //        form_chat_with = ui_chat.GetInstance(friend.Username, friend.Notename);
            //        form_chat_with.Show();
            //    }
            //}

            //if (form_chat_with != null)
            //{
            //    form_chat_with.Invoke(
            //        form_chat_with.show_text,
            //        new Object[] { msg, msg_type, form_chat_with.rtbx_receive_msg }
            //        );
            //}
            //else
            //{
            //    // 陌生人
            //}
        }
    }
}
