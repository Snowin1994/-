using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.Facility.Protocol;

namespace SecurityServer
{
    class ChatReceiveFilter : BeginEndMarkReceiveFilter<ChatRequestInfo>
    {
        private readonly Encoding encoding;
        private const string SPLITER = " ";
        private readonly static byte[] BeginMark = new byte[] { (byte)'s', (byte)'n', (byte)'o', (byte)'w', (byte)'h', (byte)'e', (byte)'a', (byte)'d' };
        private readonly static byte[] EndMark = new byte[] { (byte)'s', (byte)'n', (byte)'o', (byte)'w', (byte)'t', (byte)'a', (byte)'i', (byte)'l' };

        public ChatReceiveFilter()
            : base(BeginMark, EndMark)
        {
            encoding = Encoding.UTF8;
        }

        protected override ChatRequestInfo ProcessMatchedRequest(byte[] readBuffer, int offset, int length)
        {
            // 解析数据为CharRequestInfo实例并返回
            string source = encoding.GetString(readBuffer, offset + BeginMark.Length, length - BeginMark.Length - EndMark.Length);
            int pos = source.IndexOf(SPLITER);

            string key = String.Empty;
            string body = String.Empty;

            if(pos > 0)
            {
                key = source.Substring(0, pos);
                body = source.Substring(pos + SPLITER.Length);
            }
            else
            {
                key = source;
            }

            return new ChatRequestInfo(key, body);
        }
    }
}
