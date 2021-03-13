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
        public ActionResult Starmap()
        {
            return View();
        }

        [Route ("VerseExkurs/Starmap/{System}")]
        public IActionResult System(string System)
        {
            return View(System);
        }
        public ActionResult Technologien()
        {
            return View();
        }

        [Route("VerseExkurs/Technologien/{Technologie}")]
        public IActionResult Technologien(string Technologie)
        {
            return View(Technologie);
        }
        public ActionResult Firmen()
        {
            return View();
        }

        [Route("VerseExkurs/Firmen/{Firma}")]
        public IActionResult Firmen(string Firma)
        {
            return View(Firma);
        }
        public ActionResult Alienrassen()
        {
            return View();
        }

        [Route("VerseExkurs/Alienrassen/{Alienrasse}")]
        public IActionResult Alienrassen(string Alienrasse)
        {
            return View(Alienrasse);
        }
    }
}
