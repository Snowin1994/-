using SecurityClient.ui_design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityClient.Command
{
    class UpdatePw : ICommand
    {
        public void ExecuteCommand(string body)
        {
            ui_update_password.GetInstance(new User()).Invoke(
                ui_update_password.GetInstance(new User()).sender_msg,
                new Object[] { body }
                );
        }
    }
}
