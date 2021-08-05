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
    public class SpectrumController : Controller
    {
        string APIBaseurl = "https://cms.ariscorp.de/";


        [Route("VerseExkurs/Spectrum")]
        public async Task<IActionResult> Index()
        {
            SpectrumRootobject SpectrumInfo = new SpectrumRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/spectrum" + "?filter[spectrum_kategorie_beschreibung]=true&sort=sort,id&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var SpectrumResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    SpectrumInfo = JsonConvert.DeserializeObject<SpectrumRootobject>(SpectrumResponse);

                }
                //returning the employee list to view  
                return View(SpectrumInfo.data);
            }
        }

        //KATEGORIE-ÜBERSICHT
        [Route("VerseExkurs/Spectrum/{kategorie}")]
        public async Task<IActionResult> Kategorie(string kategorie)
        {
            SpectrumRootobject SpectrumInfo = new SpectrumRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/spectrum" + "?filter[spectrum_beitrag_kateogrie]=" + kategorie + "&sort=sort,id&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var SpectrumResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    SpectrumInfo = JsonConvert.DeserializeObject<SpectrumRootobject>(SpectrumResponse);

                }
                //returning the employee list to view  
                return View(SpectrumInfo.data);
            }
        }

        //ARTIKEL
        [Route("VerseExkurs/Spectrum/Artikel/{artikel}")]
        public async Task<IActionResult> Artikel(string artikel)
        {
            SpectrumRootobject SpectrumInfo = new SpectrumRootobject();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIBaseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("items/spectrum" + "?filter[spectrum_titel]=" + artikel + "&filter[spectrum_kategorie_beschreibung]=false&access_token=ihGAYzxCs1LWxIGBSTWbx8w3cd7oTNCobhZdmr");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var SpectrumResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    SpectrumInfo = JsonConvert.DeserializeObject<SpectrumRootobject>(SpectrumResponse);

                }
                //returning the employee list to view  
                return View(SpectrumInfo.data);
            }
        }
    }
}
