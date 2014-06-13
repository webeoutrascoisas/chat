using System.Web.Mvc;
using System.Web.Security;

namespace WebeOutrasCoisas.Chat.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn(string nome)
        {
            FormsAuthentication.SetAuthCookie(nome, false);
            return RedirectToAction("Chat");
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}