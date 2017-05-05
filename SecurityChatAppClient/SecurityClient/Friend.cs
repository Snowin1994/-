using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityClient
{
    public class Friend
    {
        private string username;
        /// <summary>
        /// 朋友的用户名
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        /// <summary>
        /// 给朋友的备注
        /// </summary>
        private string notename;

        public string Notename
        {
            get { return notename; }
            set { notename = value; }
        }
        private string signature;

        public string Signature
        {
            get { return signature; }
            set { signature = value; }
        }

        public Friend(string _nickname, string _signature)
        {
            notename = _nickname;
            signature = _signature;
        }

    }
}
