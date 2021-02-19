using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZS.SuperSocket.Session
{
    public class ChatSession : AppSession<ChatSession>
    {
        public override void Send(string message)
        {
            ///            
            base.Send(message);
        }
    }
}
