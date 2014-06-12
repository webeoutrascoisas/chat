using Microsoft.AspNet.SignalR;

namespace WebeOutrasCoisas.Chat.Web.Hubs
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.Caller.hello();
        }
    }
}