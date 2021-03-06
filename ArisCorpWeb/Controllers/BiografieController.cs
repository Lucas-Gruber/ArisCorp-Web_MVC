using ArisCorpWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Controllers
{
    public class BiografieController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult M()
        {
            BiografieModel biografie = new BiografieModel { Member_Name = "AaronPrice" };
            List<MemberModel> member_Liste = new List<MemberModel>
            {
                new MemberModel {Title="test1"},
                new MemberModel {Title="test2"}
            };

            ViewModels.BiografieViewModel viewModel = new ViewModels.BiografieViewModel();
            viewModel.Biografie = biografie;
            viewModel.Member_Liste = member_Liste;
            return View(viewModel);
        }
    }
}
