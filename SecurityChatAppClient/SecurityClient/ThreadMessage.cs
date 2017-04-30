using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityClient
{
    public class ThreadMessage
    {
        public ThreadMessage()
        {

        }

        public bool Send(string msg, System.Windows.Forms.Control control_parent, System.Windows.Forms.Control control_child)
        {
            try
            {
                

                return true;
            }
            catch (Exception ex)
            {
                // log
                Console.WriteLine(ex.StackTrace);

                return false;
            }
        }
    }
}
