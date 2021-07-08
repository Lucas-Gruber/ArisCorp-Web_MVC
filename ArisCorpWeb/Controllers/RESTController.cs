using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Controllers
{
    public class RESTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
