using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using ArisCorpWeb.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ArisCorpWeb.Areas.VerseExkurs.Controllers
{
    [Area("VerseExkurs")]
    public class StarmapController : Controller
    {
        private readonly ApplicationDBContext _context;

        public StarmapController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: VerseExkurs/Starmap
        [Route("VerseExkurs/Starmap")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        string APIBaseurl = "https://cms.ariscorp.de/";
        [Route("VerseExkurs/Starmap/{system}")]
        public async Task<ActionResult> Details(string system)
        {
            SystemeRootobject SystemInfo = new SystemeRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/systeme/" + system + "?filter[system]=true&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var SystemResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    SystemInfo = JsonConvert.DeserializeObject<SystemeRootobject>(SystemResponse);

                }
                //returning the employee list to view  
                return View(SystemInfo.data);
            }
        }

        private bool SystemeExists(string id)
        {
            return _context.Systeme.Any(e => e.Id == id);
        }
    }
}
