﻿using System;
using System.Collections.Generic;
using System.IO;
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

            Log(PublicKey, @"C:\RSA_Pub.txt");
            Log(PrivateKey, @"C:\RSA_Pri.txt");
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
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] srcByte = utf8.GetBytes(srcString);
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
                UTF8Encoding utf8 = new UTF8Encoding();

                return utf8.GetString(plainByte);
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
        public static void Log(string source, string path)
        {
            try
            {
                FileStream f = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sw = new StreamWriter(f);
                sw.WriteLine(source);
                sw.Flush();
                sw.Close();
                f.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public string PublicKey
        {
            get 
            {
                return this.ByteToString(publicKey);
            }
        }

        public string PrivateKey
        {
            get
            {
                return this.ByteToString(privateKey);
            }
        }

        private string ByteToString(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }

        private byte[] publicKey;
        private byte[] privateKey;
        private RSACryptoServiceProvider rsaService;
    }
}
