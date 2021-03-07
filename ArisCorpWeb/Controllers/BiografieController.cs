using ArisCorpWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Controllers
{
    public class BiografieController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
