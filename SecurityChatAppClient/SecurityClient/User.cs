using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityClient
{
    public class User
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string nickname;

        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        private string signature;

        public string Signature
        {
            get { return signature; }
            set { signature = value; }
        }

        internal void UpdateInfo(string _nickname, string _signature)
        {
            nickname = _nickname;
            signature = _signature;
        }
    }
}
