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
    public class BiografienController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly BiografienContext _context;

        public BiografienController(BiografienContext context)
        {
            _context = context;
        }

        // GET: Biografien
        public async Task<IActionResult> List()
        {
            return View(await _context.Biografien.ToListAsync());
        }

        // GET: Biografien/Details/5
        public async Task<IActionResult> Member(string id)
        {
            if (id == null)
            {
                return NotFound("~/Views/Biografien/BioNotFound.cshtml");
            }

            var biografien = await _context.Biografien
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biografien == null)
            {
                return View("BioNotFound");
            }

            return View(biografien);
        }

        // GET: Biografien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Biografien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Mitglied,Titel,Picture,Content1,Content2,Content3,Content4")] Biografien biografien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(biografien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(biografien);
        }

        // GET: Biografien/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biografien = await _context.Biografien.FindAsync(id);
            if (biografien == null)
            {
                return NotFound();
            }
            return View(biografien);
        }

        // POST: Biografien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Mitglied,Titel,Picture,Content1,Content2,Content3,Content4")] Biografien biografien)
        {
            if (id != biografien.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(biografien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BiografienExists(biografien.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(biografien);
        }

        // GET: Biografien/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biografien = await _context.Biografien
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biografien == null)
            {
                return NotFound();
            }

            return View(biografien);
        }

        // POST: Biografien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var biografien = await _context.Biografien.FindAsync(id);
            _context.Biografien.Remove(biografien);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }

        private bool BiografienExists(string id)
        {
            return _context.Biografien.Any(e => e.Id == id);
        }
    }
}
