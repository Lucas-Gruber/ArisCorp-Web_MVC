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
            LiteraturReihenRootobject LiteraturReiheInfo = new LiteraturReihenRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/literatur_reihen" + "?fields=status,reihen_titel,reihen_cover&filter[status]=published&sort=reihen_titel&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing LiteraturResponse response details recieved from web api   
                    var LiteraturReiheResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    LiteraturReiheInfo = JsonConvert.DeserializeObject<LiteraturReihenRootobject>(LiteraturReiheResponse);

                }
                //returning the employee list to view  
                return View(LiteraturReiheInfo.data);
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
                HttpResponseMessage Res = await client.GetAsync("items/literatur" + "?fields=*,literatur_reihe.*&deep[literatur_reihe][_filter][reihen_titel]=" + buchreihe + "&sort=sort,literatur_kapitel&filter[status]=published&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

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
                HttpResponseMessage Res = await client.GetAsync("items/literatur" + "?fields=*,literatur_reihe.reihen_titel,literatur_reihe.reihen_cover,literatur_reihe.reihen_kapitel_anzahl&filter[literatur_kapitel]=" + kapitel + "&deep[literatur_reihe][_filter][reihen_titel]=" + buch + "&filter[status]=published&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

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
