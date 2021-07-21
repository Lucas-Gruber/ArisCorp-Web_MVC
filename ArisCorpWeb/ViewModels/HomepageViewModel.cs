using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.ViewModels
{
    public class HomepageViewModel
    {
        public IEnumerable<Biografien> biografien { get; set; }
        public IEnumerable<Gameplays> gameplays { get; set; }


        public IEnumerable<BiografienIndexAPI> biografieindexapi { get; set; }
    }
}
