using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ArisCorpWeb.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ArisCorpWeb.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDBContext _context;

        public HomeController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            //var data = _bdb.Biografien.ToList();
            return View(_context.Biografien.ToList());
        }



        public async Task<IActionResult> Index()
        {
            return View(await _context.Biografien.ToListAsync());
        }
    }
}
