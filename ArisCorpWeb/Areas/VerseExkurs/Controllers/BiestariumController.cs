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
    public class BiestariumController : Controller
    {
        private readonly ApplicationDBContext _context;

        public BiestariumController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: VerseExkurs/Alienrassen/Biestarium
        [Route("VerseExkurs/Alienrassen/Biestarium2")]
        public async Task<IActionResult> Details(string id)
        {

            var biestarium = await _context.Biestarium
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biestarium == null)
            {
                return NotFound();
            }

            return View(biestarium);
        }
    }
}
