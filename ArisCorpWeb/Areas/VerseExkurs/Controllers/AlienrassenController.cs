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
    public class AlienrassenController : Controller
    {
        private readonly ApplicationDBContext _context;

        public AlienrassenController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: VerseExkurs/Alienrassen
        [Route("VerseExkurs/Alienrassen")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        string APIBaseurl = "https://cms.ariscorp.de/";
        [Route("VerseExkurs/Alienrassen/{rasse}")]
        public async Task<ActionResult> Details(string rasse)
        {
            AlienrassenRootobject AlienrasseInfo = new AlienrassenRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/alienrassen/" + rasse + "?access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var AlienrasseResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    AlienrasseInfo = JsonConvert.DeserializeObject<AlienrassenRootobject>(AlienrasseResponse);

                }
                //returning the employee list to view  
                return View(AlienrasseInfo.data);
            }
        }

        private bool AlienrassenExists(string id)
        {
            return _context.Alienrassen.Any(e => e.Id == id);
        }
    }
}
