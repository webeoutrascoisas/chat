using System.Web.Optimization;

namespace WebeOutrasCoisas.Chat.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/Bootstrap/css")
                .Include("~/Content/Bootstrap/bootstrap.css")
                .Include("~/Content/Bootstrap/bootstrap-theme.css"));

            bundles.Add(new LessBundle("~/Content/Theme")
                .Include("~/Content/css/*.less"));
        }
    }
}