using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace rsa_test_v1._0
{
    public class RSATool
    {
        public RSATool()
        {
            rsaService = new RSACryptoServiceProvider();
            publicKey = rsaService.ExportCspBlob(false);
            privateKey = rsaService.ExportCspBlob(true);
        }

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="srcString">所要加密的数据</param>
        /// <returns></returns>
        public string Encrypt(string srcString)
        {
            try
            {
                UnicodeEncoding unicode = new UnicodeEncoding();
                byte[] srcByte = unicode.GetBytes(srcString);
                byte[] cypherByte = rsaService.Encrypt(srcByte, false);

                // test
                foreach (byte data in cypherByte)
                {
                    Console.Write(data + " ");
                }
                Console.WriteLine();

                return Convert.ToBase64String(cypherByte);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("src string is null!");

                return null;
            }
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="cypher">所要解密的数据</param>
        /// <returns></returns>
        public string Decyrpt(string cypher)
        {
            try
            {
                byte[] cypherByte = Convert.FromBase64String(cypher);
                byte[] plainByte = rsaService.Decrypt(cypherByte, false);
                UnicodeEncoding unicode = new UnicodeEncoding();

                return unicode.GetString(plainByte);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("cypher string is null!");

                return null;
            }
        }


        private byte[] publicKey;
        private byte[] privateKey;
        private RSACryptoServiceProvider rsaService;
    }
}
