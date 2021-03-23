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
    public class HomeDBController : Controller
    {
        private readonly HomeDBContext _context;

        public HomeDBController(HomeDBContext context)
        {
            _context = context;
        }

        // GET: HomeDB
        public async Task<IActionResult> Index()
        {
            return View(await _context.Home.ToListAsync());
        }

        // GET: HomeDB/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeDB = await _context.Home
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeDB == null)
            {
                return NotFound();
            }

            return View(homeDB);
        }

        // GET: HomeDB/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HomeDB/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,About,History,Manifest,Charter,Member,Fleet,Partner")] HomeDB homeDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeDB);
        }

        // GET: HomeDB/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeDB = await _context.Home.FindAsync(id);
            if (homeDB == null)
            {
                return NotFound();
            }
            return View(homeDB);
        }

        // POST: HomeDB/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,About,History,Manifest,Charter,Member,Fleet,Partner")] HomeDB homeDB)
        {
            if (id != homeDB.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeDBExists(homeDB.Id))
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
            return View(homeDB);
        }

        // GET: HomeDB/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeDB = await _context.Home
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeDB == null)
            {
                return NotFound();
            }

            return View(homeDB);
        }

        // POST: HomeDB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var homeDB = await _context.Home.FindAsync(id);
            _context.Home.Remove(homeDB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeDBExists(string id)
        {
            return _context.Home.Any(e => e.Id == id);
        }
    }
}
