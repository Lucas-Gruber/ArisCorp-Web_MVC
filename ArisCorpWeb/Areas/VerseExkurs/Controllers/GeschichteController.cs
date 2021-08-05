using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ArisCorpWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ArisCorpWeb.Areas.VerseExkurs.Controllers
{
    [Area("VerseExkurs")]
    public class GeschichteController : Controller
    {
        string APIBaseurl = "https://cms.ariscorp.de/";

        [Route("VerseExkurs/Geschichte")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("VerseExkurs/Geschichte/{artikel}")]
        public async Task<ActionResult> Details(string artikel)
        {
            GeschichteRootobject GeschichteInfo = new GeschichteRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/geschichte" + "?filter[geschichte_titel]=" + artikel + "&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var GeschichteResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    GeschichteInfo = JsonConvert.DeserializeObject<GeschichteRootobject>(GeschichteResponse);

                }
                //returning the employee list to view  
                return View(GeschichteInfo.data);
            }
        }
    }
}
