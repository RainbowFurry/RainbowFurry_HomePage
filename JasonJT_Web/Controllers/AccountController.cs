using JasonJT_Web.Csharp.Manager;
using JasonJT_Web.Database;
using JasonJT_Web.Database.Model;
using JasonJT_Web.Models;
using MongoDB.Bson;
using System;
using System.Web.Mvc;
using System.Web.Security;

namespace JasonJT_Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly HashPassword hashPassword = new HashPassword();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account account)
        {

            Account acc = MongoDBManager.Instance.AccountModel.Login(account.NickName, hashPassword.CreateHash(account.Password));

            if (!string.IsNullOrEmpty(account.NickName) &&
                !string.IsNullOrEmpty(account.Password) &&
                acc != null)
            {
                FormsAuthentication.SetAuthCookie(acc.UserID, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Login failed.";
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Account account)
        {
            
            if (string.IsNullOrEmpty(account.Email) ||
                string.IsNullOrEmpty(account.NickName) ||
                string.IsNullOrEmpty(account.Password) ||
                string.IsNullOrEmpty(account.ConfirmPassword))
            {
                ViewBag.Error = "Registration failed.";
                return RedirectToAction("Registration", "Account");
            }

            account.UserID = Guid.NewGuid().ToString();
            account.Password = hashPassword.CreateHash(account.Password);
            account.ConfirmPassword = hashPassword.CreateHash(account.ConfirmPassword);
            account.Role = Models.Enum.Roles.User;

            if (MongoDBManager.Instance.CreateEntry("JasonJT_Users", account.ToBsonDocument()))
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ViewBag.Error = "Registration failed. (System side)";
                return RedirectToAction("Registration", "Account");
            }

        }

        [Authorize]
        //[ValidateAntiForgeryToken]
        public ActionResult Account()
        {
            AccountDBModel acc = new AccountDBModel();
            Account account = acc.Find(User.Identity.Name);
            
            ViewData["Banner"] = account.ProfileBanner;
            ViewData["ProfilePicture"] = account.ProfilePicture;

            ViewData["NickName"] = account.NickName;
            ViewData["FirstName"] = account.FirstName;
            ViewData["LastName"] = account.LastName;
            ViewData["Birthday"] = account.Birthday;
            ViewData["Sex"] = account.Sex;
            ViewData["Email"] = account.Email;
            ViewData["Gender"] = account.Gender;
            ViewData["Role"] = account.Role;

            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}