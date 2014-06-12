using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(WebeOutrasCoisas.Chat.Web.Startup))]

namespace WebeOutrasCoisas.Chat.Web
{

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}