using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using ArisCorpWeb.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ArisCorpWeb.Areas.VerseExkurs.Controllers
{
    [Area("VerseExkurs")]
    public class HomeController : Controller
    {
        string APIBaseurl = "https://cms.ariscorp.de/";
        [Route("VerseExkurs")]
        public async Task<ActionResult> Index()
        {
            ExkursHomeRootobject ExkursHomeInfo = new ExkursHomeRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/exkurs_index" + "?filter[status]=published&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var ExkursHomeResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    ExkursHomeInfo = JsonConvert.DeserializeObject<ExkursHomeRootobject>(ExkursHomeResponse);

                }
                //returning the employee list to view  
                return View(ExkursHomeInfo.data);
            }
        }

        [Route("VerseExkurs/Disclaimer")]
        public ActionResult Disclaimer()
        {
            return View();
        }
    }
}
