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
    public class StarmapController : Controller
    {
        private readonly ApplicationDBContext _context;

        public StarmapController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: VerseExkurs/Starmap
        [Route("VerseExkurs/Starmap")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: VerseExkurs/Starmap/5
        [Route("VerseExkurs/Starmap/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systeme = await _context.Systeme
                .FirstOrDefaultAsync(m => m.Id == id);
            if (systeme == null)
            {
                return NotFound();
            }

            return View(systeme);
        }

        private bool SystemeExists(string id)
        {
            return _context.Systeme.Any(e => e.Id == id);
        }
    }
}
