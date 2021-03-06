using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.ViewModels
{
    public class BiografieViewModel
    {
        public BiografieModel Biografie { get; set; }
        public List<MemberModel> Member_Liste { get; set; }
    }
}
