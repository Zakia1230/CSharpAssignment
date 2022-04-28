using System;
using System.Web.Mvc;

namespace TemplateDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home   

        /*/Home/Index
        /Home/Index/plain
        /Home/Index/html
        /Home/Index/xml
        /Home/Index/xyz*/
        public ActionResult Index(string id)
       {
            if (id == null)
            {
                return Content("<h1>This is a demo of ContentResult</h1>");
            } 
            else if (id.ToLower() == "plain")
            { 
                return Content("<h1>This is a demo of ContentResult</h1>", "text/plain");
            } 
            else if (id.ToLower() == "html")
            { 
                return Content("<h1>This is a demo of ContentResult</h1>", "text/html");
            } 
            else if (id.ToLower() == "xml")
            {
                return Content("<h1>This is a demo of ContentResult</h1>", "text/xml");
            }
            return Content("Invalid content type"); 
        }

        ///Home/DownloadFile
        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"e:\Nature.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"e:\Nature.jpg", "image/jpg", "default.jpg");
        }

        ///Home/Google
        public ActionResult Google()
        {
            return Redirect("http://www.google.com");
        }

        ///Home/Login
        public ActionResult Login()
        {
            return View();
        }

        ///Home/AboutUs
        public ActionResult AboutUs() 
        {
            return View();
        }
    }
}