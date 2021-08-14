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
    public class UEELebenController : Controller
    {
        string APIBaseurl = "https://cms.ariscorp.de/";
        [Route("VerseExkurs/UEE-{bereich}")]
        public async Task<ActionResult> Details(string bereich)
        {
            UEERootobject UEEInfo = new UEERootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/uee/" + bereich + "?filter[status]=published&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var UEEResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    UEEInfo = JsonConvert.DeserializeObject<UEERootobject>(UEEResponse);

                }
                //returning the employee list to view  
                return View(UEEInfo.data);
            }
        }
    }
}
