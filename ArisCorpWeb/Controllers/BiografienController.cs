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
        string APIBaseurl = "https://cms.ariscorp.de/items/";



        [Route("Biografien")]
        public async Task<IActionResult> Index()
        {
            MemberRootobject BioInfo = new MemberRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("member" + "?sort=sort,member_name&filter[status]=published&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var BioResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    BioInfo = JsonConvert.DeserializeObject<MemberRootobject>(BioResponse);

                }
                //returning the employee list to view  
                return View(BioInfo.data);
            }
        }

        [Route("Biografien/{member}")]
        public async Task<ActionResult> Member(string member)
        {
            MemberRootobject BioInfo = new MemberRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("member" + "?filter[member_name]=" + member + "&filter[status]=published&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var BioResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    BioInfo = JsonConvert.DeserializeObject<MemberRootobject>(BioResponse);

                }
                //returning the employee list to view  
                return View(BioInfo.data);
            }
        }
    }
}
