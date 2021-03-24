using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ArisCorpWeb.Areas.VerseExkurs.Controllers
{
    [Area("VerseExkurs")]
    public class Geschichte : Controller
    {
        [Route("VerseExkurs/Geschichte")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
