using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebTest1.Models;

namespace WebTest1.Controllers
{
    public class SystemController : Controller
    {
        public ActionResult Stanton()
        {
            return View();
        }
    }
}