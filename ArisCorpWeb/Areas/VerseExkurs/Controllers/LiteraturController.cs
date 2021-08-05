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
    public class LiteraturController : Controller
    {
        string APIBaseurl = "https://cms.ariscorp.de/";


        [Route("VerseExkurs/Literatur")]
        public async Task<IActionResult> Index()
        {
            LiteraturRootobject LiteraturInfo = new LiteraturRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/literatur" + "?filter[literatur_kapitel]=1&sort=id&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing LiteraturResponse response details recieved from web api   
                    var LiteraturResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    LiteraturInfo = JsonConvert.DeserializeObject<LiteraturRootobject>(LiteraturResponse);

                }
                //returning the employee list to view  
                return View(LiteraturInfo.data);
            }
        }

        //TOC
        [Route("VerseExkurs/Literatur/{Buchreihe}")]
        public async Task<IActionResult> Reihe(string buchreihe)
        {
            LiteraturRootobject LiteraturInfo = new LiteraturRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/literatur" + "?filter[literatur_titel]=" + buchreihe + "&sort=literatur_kapitel&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var LiteraturResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    LiteraturInfo = JsonConvert.DeserializeObject<LiteraturRootobject>(LiteraturResponse);

                }
                //returning the employee list to view  
                return View(LiteraturInfo.data);
            }
        }

        //ARTIKEL
        [Route("VerseExkurs/Literatur/Buch/{buch}/{kapitel}")]
        public async Task<IActionResult> Buch(string buch, int kapitel)
        {
            LiteraturRootobject LiteraturInfo = new LiteraturRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/literatur" + "?filter[literatur_titel]=" + buch + "&filter[literatur_kapitel]=" + kapitel + "&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var LiteraturResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    LiteraturInfo = JsonConvert.DeserializeObject<LiteraturRootobject>(LiteraturResponse);

                }
                else
                {
                    return View("test");
                }
                //returning the employee list to view  
                return View(LiteraturInfo.data);
            }
        }
    }
}
