using SecurityClient.ui_design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityClient.Command
{
    class Login : ICommand
    {
        public void ExecuteCommand(string body)
        {
            ui_login.GetInstance().Invoke(
                ui_login.GetInstance().sender_msg,
                new Object[] { body }
                );
        }
    }
}
