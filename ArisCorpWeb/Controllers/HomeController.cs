using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ArisCorpWeb.Models;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Data;
using ArisCorpWeb.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ArisCorpWeb.Controllers
{
    public class HomeController : Controller
    {
        string APIBaseurl = "https://cms.ariscorp.de/";

        public async Task<IActionResult> Index()
        {
            HomeRootobject HomeInfo = new HomeRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/homepage/1" + "?fields=*.*,ariscorp_comm_links.comm_link_channel.channel&filter[status]=published&deep[ariscorp_comm_links][_limit]=4&deep[ariscorp_comm_links][_filter][status]=published&deep[ariscorp_partner][_filter][status]=published&deep[ariscorp_comm_links][_sort]=-date_created&deep[ariscorp_mitglieder][_filter][status]=published&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var HomeResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    HomeInfo = JsonConvert.DeserializeObject<HomeRootobject>(HomeResponse);

                }
                //returning the employee list to view  
                return View(HomeInfo.data);
            }
        }
    }
}
