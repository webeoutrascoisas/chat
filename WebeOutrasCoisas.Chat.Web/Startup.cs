using System.Web.Optimization;
using Microsoft.Owin;
using Owin;
using System.Web.Mvc;
using System.Web.Routing;
[assembly: OwinStartup(typeof(WebeOutrasCoisas.Chat.Web.Startup))]

namespace WebeOutrasCoisas.Chat.Web
{

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}