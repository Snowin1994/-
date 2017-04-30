using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityServer
{
    public class Common
    {
        public static int StringToInt(string str)
        {
            int num = 0;
            try
            {
                num = int.Parse(str);
            }
            catch(Exception e)
            {
                // 通过log记录异常信息

                num = 0;
            }

            return num;
        }
    }
}
