using System.Web.Mvc;

namespace JasonJT_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.Cookies["MainColor"] == null)
            {
                return RedirectToAction("SetDefaultCookies", "Cookie");
            }
            return View();
        }

        public ActionResult Status()
        {
            return View();
        }

        public ActionResult CreatorProfile()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

    }
}