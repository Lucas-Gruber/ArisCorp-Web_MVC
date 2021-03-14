using ArisCorpWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Controllers
{
    public class BiografienController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public IActionResult AaronPrice()
        {
            if(ViewExists(AaronPrice))
            {
                return View();
            }
            else
            {
                return View("fehler");
            }
        }

        private bool ViewExists(Func<IActionResult> aaronPrice)
        {
            throw new NotImplementedException();
        }

        public ActionResult Member()
        {
            return View();
        }

    }
}
