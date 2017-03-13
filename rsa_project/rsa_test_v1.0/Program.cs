using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsa_test_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string src = "This is Snowin's home!";

            RSATool rsa_tool = new RSATool();
            string cypher = rsa_tool.Encrypt(src);
            Console.WriteLine(cypher);
            Console.WriteLine();

            string plain = rsa_tool.Decyrpt(cypher);
            Console.WriteLine(plain);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
