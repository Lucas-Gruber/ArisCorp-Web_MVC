﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Areas.VerseExkurs.Controllers
{
    [Area("VerseExkurs")]
    public class HomeController : Controller
    {
        [Route("VerseExkurs")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("VerseExkurs/Disclaimer")]
        public ActionResult Disclaimer()
        {
            return View();
        }

        [Route("VerseExkurs/Alienrassen")]
        public IActionResult Alienrassen()
        {
            return View("AlienrassenList");
        }

        [Route("VerseExkurs/Starmap")]
        public IActionResult Starmap()
        {
            return View("StarmapList");
        }

        [Route("VerseExkurs/Technologien")]
        public IActionResult Technologien()
        {
            return View("TechnologienList");
        }

        private readonly ApplicationDBContext _context;
        public HomeController(ApplicationDBContext context)
        {
            _context = context;
        }

        [Route("VerseExkurs/Alienrassen/{id}")]
        public async Task<IActionResult> Alienrassen(string id)
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

        [Route("VerseExkurs/Starmap/{id}")]
        public async Task<IActionResult> Starmap(string id)
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

        [Route("VerseExkurs/Technologien/{id}")]
        public async Task<IActionResult> Technologien(string id)
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
    }
}