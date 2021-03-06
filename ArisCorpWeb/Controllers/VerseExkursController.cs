using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Controllers
{
    public class VerseExkursController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Disclaimer()
        {
            return View();
        }
<<<<<<< HEAD:ArisCorpWeb/Controllers/VerseExkursController.cs

        [Route ("VerseExkurs/Systeme/{System}")]
        public IActionResult System(string System)
        {
            return View(System);
=======
        public IActionResult Systeme(string System)
        {
            return Content("System=" + System);
>>>>>>> alpha:WebTest1/Controllers/VerseExkursController.cs
        }
    }
}