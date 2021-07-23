using System.Web.Mvc;

namespace JasonJT_Web.Controllers
{
    public class GenderController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SexIntroduction()
        {
            return View();
        }

        public ActionResult GenderIntroduction()
        {
            return View();
        }

        public ActionResult SexResult()
        {
            return View();
        }

        public ActionResult GenderResult()
        {
            return View();
        }

        public ActionResult SexQuestions()
        {
            return View();
        }

        public ActionResult GenderQuestions()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SexQuestions(int index)
        {

            ViewData["Index"] = index;

            return View();
        }

        [HttpGet]
        public ActionResult GenderQuestions(int index)
        {

            ViewData["Index"] = index;

            return View();
        }

        public ActionResult Advisor()
        {
            return View();
        }

        public ActionResult Sign()
        {
            return View();
        }

        public ActionResult Sexuallitys()
        {
            return View();
        }

    }
}