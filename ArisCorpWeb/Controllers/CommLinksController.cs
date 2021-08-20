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

namespace ArisCorpWeb.Controllers
{
    public class CommLinksController : Controller
    {
        string APIBaseurl = "https://cms.ariscorp.de/";


        [Route("comm-link")]
        public async Task<IActionResult> Index()
        {
            CommLinksRootobject CommLinksInfo = new CommLinksRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/comm_links" + "?sort=-date_created&filter[status]=published&fields=*,comm_link_channel.channel&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var CommLinksResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    CommLinksInfo = JsonConvert.DeserializeObject<CommLinksRootobject>(CommLinksResponse);

                }
                //returning the employee list to view  
                return View(CommLinksInfo.data);
            }
        }

        //KATEGORIE-ÜBERSICHT
        [Route("comm-link/transmission/{commlink}")]
        public async Task<IActionResult> Artikel(string commlink)
        {
            CommLinksRootobject CommLinksInfo = new CommLinksRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/comm_links" + "?filter[comm_link_titel]=" + commlink + "&filter[status]=published&fields=*,comm_link_channel.channel&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var CommLinksResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    CommLinksInfo = JsonConvert.DeserializeObject<CommLinksRootobject>(CommLinksResponse);

                }
                //returning the employee list to view  
                return View(CommLinksInfo.data);
            }
        }
    }
}
