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
            Console.WriteLine("请输入需要加密的文字：");
            string src = Console.ReadLine();
            Console.WriteLine();
            
            RSATool rsa_tool = new RSATool();
            string cypher = rsa_tool.Encrypt(src);
            Console.WriteLine("加密后的文字：");
            Console.WriteLine(cypher);
            Console.WriteLine();

            string plain = rsa_tool.Decyrpt(cypher);
            Console.WriteLine("解密后的文字：");
            Console.WriteLine(plain);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
