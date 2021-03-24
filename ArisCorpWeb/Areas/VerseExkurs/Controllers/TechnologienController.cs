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
    public class TechnologienController : Controller
    {
        private readonly ApplicationDBContext _context;

        public TechnologienController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: VerseExkurs/Technologien
        public async Task<IActionResult> Index()
        {
            return View(await _context.Technologien.ToListAsync());
        }

        // GET: VerseExkurs/Technologien/5
        [Route("VerseExkurs/Technologien/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var technologien = await _context.Technologien
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technologien == null)
            {
                return NotFound();
            }

            return View(technologien);
        }

        private bool TechnologienExists(string id)
        {
            return _context.Technologien.Any(e => e.Id == id);
        }
    }
}
