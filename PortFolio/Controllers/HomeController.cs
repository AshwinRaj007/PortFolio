using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortFolio.Models;

namespace PortFolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactModel model)
        {
            // Here you can save to database or send email

            TempData["Success"] = "Your message has been sent successfully!";

            return RedirectToAction("Index");
        }
    }
}
