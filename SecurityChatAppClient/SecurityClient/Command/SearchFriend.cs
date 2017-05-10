using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityClient.ui_design;

namespace SecurityClient.Command
{
    class SearchFriend : ICommand
    {
        public void ExecuteCommand(string body)
        {
            ui_search_friends.GetInstance().Invoke(
                ui_search_friends.GetInstance().show_result,
                new Object[] { body }
                );
        }
    }
}
