using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class BiografieModel
    {
        //[Required(ErrorMessage = "Person unbekannt.")]
        public string Member_Name { get; set; }

        //[Required(ErrorMessage = "Biografie unbekannt.")]
        public string Bio_Title { get; set; }

        //[Required(ErrorMessage = "d")]
        public string Bio_Content { get; set; }

        //[Required(ErrorMessage = "/assets/img/member/Unbekannt.png")]
        public string Member_Picture { get; set; }
    }
}
