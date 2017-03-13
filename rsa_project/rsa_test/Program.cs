using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace rsa_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcString = "I am Snowin, this is my world!";
            Console.WriteLine("src:" + srcString + "  len:" + srcString.Length);
            Console.WriteLine();
            string publicKey;
            string privateKey;

            string cypherString = Encrypt(srcString, out publicKey, out privateKey);
            Console.WriteLine("cypher:" + cypherString);
            Console.WriteLine("publicKey:" + publicKey);
            Console.WriteLine("private:" + privateKey);
            Console.WriteLine();

            string plainString = Decrypt(cypherString, privateKey);
            Console.WriteLine("plain:" + plainString);
            Console.ReadKey();

        }

        // 加密
        public static string Encrypt(string srcString, out string publicKey, out string privateKey)
        {
            privateKey = "";
            publicKey = "";
            UnicodeEncoding uncode = new UnicodeEncoding();
            byte[] srcByte = uncode.GetBytes(srcString);
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                byte[] cypherByte = rsa.Encrypt(srcByte, false);    // donnot use OAEP, what is OAEP

                publicKey = Convert.ToBase64String(rsa.ExportCspBlob(false));
                privateKey = Convert.ToBase64String(rsa.ExportCspBlob(true));

                return Convert.ToBase64String(cypherByte);
            }
            catch(CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine("src string is null!");

                return null;
            }
        }

        // 解密
        public static string Decrypt(string cypherString, string privateKey)
        {
            byte[] cypherByte = Convert.FromBase64String(cypherString);
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                byte[] privateKeyByte = Convert.FromBase64String(privateKey);
                rsa.ImportCspBlob(privateKeyByte);

                byte[] plainByte = rsa.Decrypt(cypherByte, false);
                UnicodeEncoding uncode = new UnicodeEncoding();

                return uncode.GetString(plainByte);
            }
            catch(CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("cypher string is null!");

                return null;
            }
        }
    }
}
