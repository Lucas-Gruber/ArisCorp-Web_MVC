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
    public class AlienrassenController : Controller
    {
        private readonly ApplicationDBContext _context;

        public AlienrassenController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Alienrassen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alienrassen.ToListAsync());
        }

        // GET: Alienrassen/Details/5
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

        // GET: Alienrassen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alienrassen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rasse,PictureEinleitung,PictureGeschichte,PictureHeimatwelt,PicturePolitik,PictureDiplomatie,PictureSprache,PictureReligion,PictureMilitar,PictureKriminalitat,PictureKultur,PictureBesuch,PictureSicherheit,Einleitung,Geschichte,Heimatwelt,Politik,Diplomatie,Sprache,Religion,Militar,Kriminalitat,Kultur,Besuch,Sicherheit")] Alienrassen alienrassen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alienrassen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alienrassen);
        }

        // GET: Alienrassen/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alienrassen = await _context.Alienrassen.FindAsync(id);
            if (alienrassen == null)
            {
                return NotFound();
            }
            return View(alienrassen);
        }

        // POST: Alienrassen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Rasse,PictureEinleitung,PictureGeschichte,PictureHeimatwelt,PicturePolitik,PictureDiplomatie,PictureSprache,PictureReligion,PictureMilitar,PictureKriminalitat,PictureKultur,PictureBesuch,PictureSicherheit,Einleitung,Geschichte,Heimatwelt,Politik,Diplomatie,Sprache,Religion,Militar,Kriminalitat,Kultur,Besuch,Sicherheit")] Alienrassen alienrassen)
        {
            if (id != alienrassen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alienrassen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlienrassenExists(alienrassen.Id))
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
            return View(alienrassen);
        }

        // GET: Alienrassen/Delete/5
        public async Task<IActionResult> Delete(string id)
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

        // POST: Alienrassen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var alienrassen = await _context.Alienrassen.FindAsync(id);
            _context.Alienrassen.Remove(alienrassen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlienrassenExists(string id)
        {
            return _context.Alienrassen.Any(e => e.Id == id);
        }
    }
}
