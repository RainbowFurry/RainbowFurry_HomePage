using System;
using System.Web.Mvc;

namespace JasonJT_Web.Controllers
{
    public class CookieController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SetDefaultCookies()
        {
            CreateDefaultCookies();
            return RedirectToAction("Index", "Home");
        }

        #region Cookie Manager
        /// <summary>
        /// Create the Cookies needed for Zero_Web
        /// </summary>
        public void CreateDefaultCookies()
        {

            CreateCookie("UserName", "---");

            CreateCookie("Language", "de-De");
            CreateCookie("MainColor", "#436262");
            CreateCookie("Theme", "Dark");
            CreateCookie("Style", "rounded");

        }

        /// <summary>
        /// Clear all Cookies
        /// </summary>
        public void ClearCookies()
        {
            //
        }


        /// <summary>
        /// Create the Cookies
        /// </summary>
        public void CreateCookie(String cookieName, String cookieContent)
        {
            Response.Cookies[cookieName].Value = cookieContent;
        }

        /// <summary>
        /// Delete the Cookie you want to
        /// </summary>
        /// <param name="cookieName"></param>
        public void DeleteCookie(String cookieName)
        {
            if (Request.Cookies[cookieName] != null)
            {
                Response.Cookies[cookieName].Expires = DateTime.Now.AddDays(-1);
            }
        }

        /// <summary>
        /// Return the Cookie you are looking for
        /// </summary>
        /// <param name="cookieName"></param>
        /// <returns></returns>
        public String GetCookie(String cookieName)
        {
            return Request.Cookies[cookieName].Value.ToString();
        }
        #endregion

    }
}