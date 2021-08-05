using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ArisCorpWeb.Models;
using ArisCorpWeb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Controllers
{
	public class IdentityController : Controller
	{
        [Route("Identity")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
