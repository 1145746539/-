using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZS.SuperSocket.Session;

namespace ZS.SuperSocket.Server
{
    /// <summary>
    /// 服务器 需要继承AppServer<> 需要指定session
    /// </summary>
    class ChatServer : AppServer<ChatSession>
    {
        protected override void OnNewSessionConnected(ChatSession session)
        {
            Console.WriteLine($"有新的链接加入进来：{session.LocalEndPoint.Address}");
            base.OnNewSessionConnected(session);
        }
    }
}
