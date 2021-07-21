using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using ArisCorpWeb.Models;
using ArisCorpWeb.ViewModels;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;

namespace ArisCorpWeb.Controllers
{
    public class BiografienController : Controller
    {

        [Route("Biografien")]
        public async Task<IActionResult> Index()
        {
            BioIndexRootobject BioIndexInfo = new BioIndexRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/member/");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var BioIndexResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    BioIndexInfo = JsonConvert.DeserializeObject<BioIndexRootobject>(BioIndexResponse);

                }
                //returning the employee list to view  
                return View(BioIndexInfo.data);
            }
        }

        private readonly ApplicationDBContext _context;

        public BiografienController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Biografien
        public async Task<IActionResult> List()
        {
            return View(await _context.Biografien.ToListAsync());
        }

        // GET: Biografien/Details/5
        /** [Route("Biografien/{id}")]
        public async Task<IActionResult> Member(string id)
        {
            if (id == null)
            {
                return NotFound("~/Views/Biografien/BioNotFound.cshtml");
            }

            var biografien = await _context.Biografien
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biografien == null)
            {
                return View("BioNotFound");
            }

            return View(biografien);
        } **/

        //Hosted web API REST Service base url  

        string APIBaseurl = "https://cms.ariscorp.de/";
        [Route("Biografien/{mem}")]
        public async Task<ActionResult> Member(string mem)
        {
            BioRootobject BioInfo = new BioRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/member/" + mem);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var BioResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    BioInfo = JsonConvert.DeserializeObject<BioRootobject>(BioResponse);

                }
                //returning the employee list to view  
                return View(BioInfo.data);
            }
        }
    }
}
