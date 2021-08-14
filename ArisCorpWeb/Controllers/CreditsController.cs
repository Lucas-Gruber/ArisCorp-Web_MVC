using ArisCorpWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ArisCorpWeb.Controllers
{
    public class CreditsController : Controller
    {
        string APIBaseurl = "https://cms.ariscorp.de/";
        public async Task<ActionResult> Index()
        {
            CreditsRootobject CreditsInfo = new CreditsRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/credits/" + "?filter[status]=published&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var CreditsResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    CreditsInfo = JsonConvert.DeserializeObject<CreditsRootobject>(CreditsResponse);

                }
                //returning the employee list to view  
                return View(CreditsInfo.data);
            }
        }
    }
}
