using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityServer.DbOperation
{
    class Friend
    {
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

        public Friend(string _nickname, string _signature)
        {
            nickname = _nickname;
            signature = _signature;
        }

    }
}
