using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase.Protocol;

namespace SecurityServer
{
    public class ChatRequestInfo : IRequestInfo
    {
        private string key;

        public string Key 
        { 
            get { return key; }
        }

        private string body;

        public string Body 
        { 
            get { return body; }
        }

        public ChatRequestInfo(string _key, string _body)
        {
            key = _key;
            body = _body;
        }
    }
}
