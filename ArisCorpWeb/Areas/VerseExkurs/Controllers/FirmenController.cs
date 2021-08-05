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
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ArisCorpWeb.Areas.VerseExkurs.Controllers
{
    [Area("VerseExkurs")]
    public class FirmenController : Controller
    {
        string APIBaseurl = "https://cms.ariscorp.de/";


        //HERSTELLER
        [Route("VerseExkurs/Firmen/Hersteller")]
        public async Task<IActionResult> Hersteller()
        {
            FirmenRootobject FirmenInfo = new FirmenRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/firmen" + "?sort=sort,firmen_name&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing LiteraturResponse response details recieved from web api   
                    var FirmenResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    FirmenInfo = JsonConvert.DeserializeObject<FirmenRootobject>(FirmenResponse);

                }
                //returning the employee list to view  
                return View(FirmenInfo.data);
            }
        }


        //DIENSTLEISTER
        [Route("VerseExkurs/Firmen/Dienstleister")]
        public async Task<IActionResult> Dienstleister()
        {
            FirmenRootobject FirmenInfo = new FirmenRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/firmen" + "?filter[firmenkategorie]=dienstleister&sort=sort,firmen_name&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing LiteraturResponse response details recieved from web api   
                    var FirmenResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    FirmenInfo = JsonConvert.DeserializeObject<FirmenRootobject>(FirmenResponse);

                }
                //returning the employee list to view  
                return View(FirmenInfo.data);
            }
        }


        //GESCHÄFTE
        [Route("VerseExkurs/Firmen/Geschäfte")]
        public async Task<IActionResult> Geschäfte()
        {
            FirmenRootobject FirmenInfo = new FirmenRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/firmen" + "?filter[firmenkategorie]=geschäfte&sort=sort,firmen_name&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing LiteraturResponse response details recieved from web api   
                    var FirmenResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    FirmenInfo = JsonConvert.DeserializeObject<FirmenRootobject>(FirmenResponse);

                }
                //returning the employee list to view  
                return View(FirmenInfo.data);
            }
        }


        //ORGANISATIONEN
        [Route("VerseExkurs/Firmen/Organisationen")]
        public async Task<IActionResult> Organisationen()
        {
            FirmenRootobject FirmenInfo = new FirmenRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/firmen" + "?filter[firmenkategorie]=organisation&sort=sort,firmen_name&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing LiteraturResponse response details recieved from web api   
                    var FirmenResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    FirmenInfo = JsonConvert.DeserializeObject<FirmenRootobject>(FirmenResponse);

                }
                //returning the employee list to view  
                return View(FirmenInfo.data);
            }
        }


        //VERSCHIEDENES
        [Route("VerseExkurs/Firmen/Verschiedenes")]
        public async Task<IActionResult> Verschiedenes()
        {
            FirmenRootobject FirmenInfo = new FirmenRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/firmen" + "?filter[firmenkategorie]=verschiedenes&sort=sort,firmen_name&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing LiteraturResponse response details recieved from web api   
                    var FirmenResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    FirmenInfo = JsonConvert.DeserializeObject<FirmenRootobject>(FirmenResponse);

                }
                //returning the employee list to view  
                return View(FirmenInfo.data);
            }
        }


        //Detail
        [Route("VerseExkurs/Firmen/{firma}")]
        public async Task<IActionResult> Detail(string firma)
        {
            FirmenRootobject FirmenInfo = new FirmenRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/firmen" + "?filter[firmen_name]=" + firma + "&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing LiteraturResponse response details recieved from web api   
                    var FirmenResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    FirmenInfo = JsonConvert.DeserializeObject<FirmenRootobject>(FirmenResponse);

                }
                //returning the employee list to view  
                return View(FirmenInfo.data);
            }
        }
    }
}
