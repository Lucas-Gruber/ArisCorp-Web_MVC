using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using ArisCorpWeb.Models;
using ArisCorpWeb.ViewModels;

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

        public async Task<IActionResult> Hersteller()
        {
            var model = new FirmenViewModel();
            model.hersteller_raumschiffe = _context.Firmen_Hersteller_Raumschiffe.ToList();
            model.hersteller_komponenten = _context.Firmen_Hersteller_Komponenten.ToList();
            model.hersteller_waffen = _context.Firmen_Hersteller_Waffen.ToList();
            model.hersteller_personenausrüstung = _context.Firmen_Hersteller_Personenausrüstung.ToList();
            return View(model);
        }
        public async Task<IActionResult> Dienstleister()
        {
            var model = new FirmenViewModel();
            model.dienstleister = _context.Firmen_Dienstleister.ToList();
            return View(model);
        }
        public async Task<IActionResult> Geschäfte()
        {
            var model = new FirmenViewModel();
            model.geschäfte = _context.Firmen_Geschäfte.ToList();
            return View(model);
        }
        public async Task<IActionResult> Organisationen()
        {
            var model = new FirmenViewModel();
            model.organisationen = _context.Firmen_Organisationen.ToList();
            return View(model);
        }
        public async Task<IActionResult> Verschiedenes()
        {
            var model = new FirmenViewModel();
            model.verschiedenes = _context.Firmen_Verschiedenes.ToList();
            return View(model);
        }

        // GET: VerseExkurs/Firmen
        [Route("VerseExkurs/Firmen")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: VerseExkurs/Firmen/5
        [Route("VerseExkurs/Firmen/{id?}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return View();
            }

            var hersteller_raumschiffe = await _context.Firmen_Hersteller_Raumschiffe
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hersteller_raumschiffe == null)
            {
                var hersteller_komponenten = await _context.Firmen_Hersteller_Komponenten
                .FirstOrDefaultAsync(m => m.Id == id);
                if (hersteller_komponenten == null)
                {
                    var hersteller_waffen = await _context.Firmen_Hersteller_Waffen
                .FirstOrDefaultAsync(m => m.Id == id);
                    if (hersteller_waffen == null)
                    {
                        var hersteller_personenausrüstung = await _context.Firmen_Hersteller_Personenausrüstung
                .FirstOrDefaultAsync(m => m.Id == id);
                        if (hersteller_personenausrüstung == null)
                        {
                            var dienstleister = await _context.Firmen_Dienstleister
                .FirstOrDefaultAsync(m => m.Id == id);
                            if (dienstleister == null)
                            {
                                var geschäfte = await _context.Firmen_Geschäfte
                .FirstOrDefaultAsync(m => m.Id == id);
                                if (geschäfte == null)
                                {
                                    var organisationen = await _context.Firmen_Organisationen
                .FirstOrDefaultAsync(m => m.Id == id);
                                    if (organisationen == null)
                                    {
                                        var verschiedenes = await _context.Firmen_Verschiedenes
                .FirstOrDefaultAsync(m => m.Id == id);
                                        if (verschiedenes == null)
                                        {
                                            return NotFound();
                                        }

                                        return View("Details_Verschiedenes", verschiedenes);
                                    }

                                    return View("Details_Organisationen", organisationen);
                                }

                                return View("Details_Geschäfte", geschäfte);
                            }

                            return View("Details_Dienstleister", dienstleister);
                        }

                        return View("Details_Hersteller_Personenausrüstung", hersteller_personenausrüstung);
                    }

                    return View("Details_Hersteller_Waffen", hersteller_waffen);
                }

                return View("Details_Hersteller_Komponenten", hersteller_komponenten);
            }

            return View("Details_Hersteller_Raumschiffe", hersteller_raumschiffe);
        }
        private bool DienstleisterExists(string id)
        {
            return _context.Firmen_Dienstleister.Any(e => e.Id == id);
        }
        private bool GeschäfteExists(string id)
        {
            return _context.Firmen_Geschäfte.Any(e => e.Id == id);
        }
        private bool OrganisationenExists(string id)
        {
            return _context.Firmen_Organisationen.Any(e => e.Id == id);
        }
        private bool VerschiedenesExists(string id)
        {
            return _context.Firmen_Verschiedenes.Any(e => e.Id == id);
        }


        private bool HerstellerRaumschiffeExists(string id)
        {
            return _context.Firmen_Hersteller_Raumschiffe.Any(e => e.Id == id);
        }
        private bool HerstellerKomponentenExists(string id)
        {
            return _context.Firmen_Hersteller_Komponenten.Any(e => e.Id == id);
        }
        private bool HerstellerWaffenExists(string id)
        {
            return _context.Firmen_Hersteller_Waffen.Any(e => e.Id == id);
        }
        private bool HerstellerPersonenausrüstungExists(string id)
        {
            return _context.Firmen_Hersteller_Personenausrüstung.Any(e => e.Id == id);
        }
    }
}
