using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Confirm(string Name, string Email, string Password)
        {
            ViewData["Name"] = Name;
            ViewData["Email"] = Email;
            ViewData["Password"] = Password;
            return View();
        }
    }
}
