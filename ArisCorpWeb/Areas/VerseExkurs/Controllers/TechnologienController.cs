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
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ArisCorpWeb.Areas.VerseExkurs.Controllers
{
    [Area("VerseExkurs")]
    public class TechnologienController : Controller
    {
        private readonly ApplicationDBContext _context;

        public TechnologienController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: VerseExkurs/Technologien
        public async Task<IActionResult> Index()
        {
            return View(await _context.Technologien.ToListAsync());
        }

        string APIBaseurl = "https://cms.ariscorp.de/";
        [Route("VerseExkurs/Technologien/{technologie}")]
        public async Task<ActionResult> Details(string technologie)
        {
            TechnologieRootobject TechnologieInfo = new TechnologieRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/technologien/" + technologie.Replace("_", "") + "?access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var TechnologieResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    TechnologieInfo = JsonConvert.DeserializeObject<TechnologieRootobject>(TechnologieResponse);

                }
                //returning the employee list to view  
                return View(TechnologieInfo.data);
            }
        }

        private bool TechnologienExists(string id)
        {
            return _context.Technologien.Any(e => e.Id == id);
        }
    }
}
