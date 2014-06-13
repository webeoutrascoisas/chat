using Microsoft.AspNet.SignalR;

namespace WebeOutrasCoisas.Chat.Web.Hubs
{
    public class ChatHub : Hub
    {
        [Authorize]
        public void SendMessage(string message)
        {
            Clients.Others.receiveMessage(Context.User.Identity.Name + ": " + message);
        }
    }
}