using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Controllers
{
    public class SystemeController : Controller
    {
        private readonly SystemeContext _context;

        public SystemeController(SystemeContext context)
        {
            _context = context;
        }

        // GET: Systeme
        public async Task<IActionResult> Index()
        {
            return View(await _context.Systeme.ToListAsync());
        }

        // GET: Systeme/Details/5
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

        // GET: Systeme/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Systeme/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,System,Extra1,Extra2,Extra3,Extra4,Extra5,Picture1,Picture2,Picture3,Picture4,Picture5,Picture6,Picture7,Picture8,Picture9,Picture10,Content1,Content2,Content3,Content4,Content5,Content6,Content7,Content8,Content9,Content10,Content11,Content12,Content13,Content14,Content15,Content16,Content17,Content18,Content19,Content20,Content21,Content22,Content23,Content24,Content25,Content26,Content27,Content28,Content29,Content30,Reisewarunung,FlusternImWind")] Systeme systeme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(systeme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(systeme);
        }

        // GET: Systeme/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var systeme = await _context.Systeme.FindAsync(id);
            if (systeme == null)
            {
                return NotFound();
            }
            return View(systeme);
        }

        // POST: Systeme/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,System,Extra1,Extra2,Extra3,Extra4,Extra5,Picture1,Picture2,Picture3,Picture4,Picture5,Picture6,Picture7,Picture8,Picture9,Picture10,Content1,Content2,Content3,Content4,Content5,Content6,Content7,Content8,Content9,Content10,Content11,Content12,Content13,Content14,Content15,Content16,Content17,Content18,Content19,Content20,Content21,Content22,Content23,Content24,Content25,Content26,Content27,Content28,Content29,Content30,Reisewarunung,FlusternImWind")] Systeme systeme)
        {
            if (id != systeme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(systeme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SystemeExists(systeme.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(systeme);
        }

        // GET: Systeme/Delete/5
        public async Task<IActionResult> Delete(string id)
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

        // POST: Systeme/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var systeme = await _context.Systeme.FindAsync(id);
            _context.Systeme.Remove(systeme);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SystemeExists(string id)
        {
            return _context.Systeme.Any(e => e.Id == id);
        }
    }
}
