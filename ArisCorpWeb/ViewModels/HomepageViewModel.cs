using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.ViewModels
{
    public class HomepageViewModel
    {
        public IEnumerable<Biografien> Biografien { get; set; }
    }
}
