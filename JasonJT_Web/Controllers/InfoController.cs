using JasonJT_Web.Models.Enum;
using System;
using System.IO;
using System.Web.Mvc;

namespace JasonJT_Web.Controllers
{
    public class InfoController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string name, string email, Gender gender, Sex sex, string text)
        {

            string path = Server.MapPath("~/Data/Contact/");
            string fileName = Guid.NewGuid().ToString();
            string content = "";

            Models.Contact contact = new Models.Contact()
            {
                Name = name,
                Email = email,
                Gender = gender,
                Sex = sex,
                Text = text
            };

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            content = "Name: " + contact.Name + "\n" +
                      "Email: " + contact.Email + "\n" +
                      "Gender: " + contact.Gender + "\n" +
                      "Sex: " + contact.Sex + "\n" +
                      "Text: " + contact.Text + "\n";

            System.IO.File.Create(path + fileName).Close();
            System.IO.File.AppendAllText(path + fileName, content);

            return View();
        }

        public ActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Feedback(string name, int rating, string text)
        {

            string path = Server.MapPath("~/Data/Feedback/");
            string fileName = "Feedback.txt";
            //string fileName = Guid.NewGuid().ToString();
            string content = "";

            Models.Feedback feedback = new Models.Feedback()
            {
                Name = name,
                Rating = rating.ToString(),
                Date = DateTime.Now.ToString("G"),
                Text = text
            };

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            content = "Name: " + feedback.Name + "\n" +
                      "Rating: " + feedback.Rating + "\n" +
                      "Date: " + feedback.Date + "\n" +
                      "Text: " + feedback.Text + "\n" +
                      "-\n";

            if (!System.IO.File.Exists(path + fileName))
                System.IO.File.Create(path + fileName).Close();
            System.IO.File.AppendAllText(path + fileName, content);

            return RedirectToAction("Feedback", "Info");
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult AGB()
        {
            return View();
        }

    }
}