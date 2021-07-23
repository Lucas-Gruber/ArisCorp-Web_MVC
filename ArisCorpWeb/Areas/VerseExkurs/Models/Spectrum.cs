using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    //List
    public class SpectrumRootobject
    {
        public SpectrumAPI[] data { get; set; }
    }

    public class SpectrumAPI
    {
        public string id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string text { get; set; }
        public string kategorie { get; set; }
        public string publish_date { get; set; }
        public object user_created { get; set; }
        public object date_created { get; set; }
        public string user_updated { get; set; }
        public object date_updated { get; set; }
        public object cover { get; set; }
        public bool kategorie_beschreibung { get; set; }
    }
}
