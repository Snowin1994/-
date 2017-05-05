using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecurityClient.ui_design;

namespace SecurityClient.Command
{
    class FriendList : ICommand
    {
        public void ExecuteCommand(string body)
        {
            ui_main_panel ui = ui_main_panel.GetInstance(new User());

            ui.Invoke(
                ui.show_list,
                new Object[] { body, ui.lsb_friends }
                );
        }
    }
}
