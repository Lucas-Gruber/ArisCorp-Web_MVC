using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Areas.VerseExkurs.Controllers
{
    [Area("VerseExkurs")]
    public class FirmenController : Controller
    {
        private readonly ApplicationDBContext _context;

        public FirmenController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Hersteller()
        {
            return View();
        }
        public IActionResult Dienstleister()
        {
            return View();
        }
        public IActionResult Geschäfte()
        {
            return View();
        }
        public IActionResult Organisationen()
        {
            return View();
        }
        public IActionResult Verschiedenes()
        {
            return View();
        }

        // GET: VerseExkurs/Firmen
        [Route("VerseExkurs/Firmen")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: VerseExkurs/Firmen/5
        [Route("VerseExkurs/Firmen/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firmen = await _context.Firmen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (firmen == null)
            {
                return NotFound();
            }

            return View(firmen);
        }

        private bool FirmenExists(string id)
        {
            return _context.Firmen.Any(e => e.Id == id);
        }
    }
}
