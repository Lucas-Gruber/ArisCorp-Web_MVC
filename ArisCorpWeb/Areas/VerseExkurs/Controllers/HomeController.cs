using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Areas.VerseExkurs.Controllers
{
    [Area("VerseExkurs")]
    public class HomeController : Controller
    {
        [Route("VerseExkurs")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("VerseExkurs/Disclaimer")]
        public ActionResult Disclaimer()
        {
            return View();
        }

        private readonly ApplicationDBContext _context;
        public HomeController(ApplicationDBContext context)
        {
            _context = context;
        }
    }
}
