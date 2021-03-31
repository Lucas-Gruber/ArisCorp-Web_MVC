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
    public class AlienrassenController : Controller
    {
        private readonly ApplicationDBContext _context;

        public AlienrassenController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: VerseExkurs/Alienrassen
        [Route("VerseExkurs/Alienrassen")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: VerseExkurs/Alienrassen/5
        [Route("VerseExkurs/Alienrassen/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alienrassen = await _context.Alienrassen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alienrassen == null)
            {
                return NotFound();
            }

            return View(alienrassen);
        }

        private bool AlienrassenExists(string id)
        {
            return _context.Alienrassen.Any(e => e.Id == id);
        }
    }
}
