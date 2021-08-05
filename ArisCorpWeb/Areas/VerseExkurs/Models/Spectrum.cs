using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class SpectrumRootobject
    {
        public SpectrumAPI[] data { get; set; }
    }

    public class SpectrumAPI
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public object date_updated { get; set; }
        public string spectrum_titel { get; set; }
        public string spectrum_text { get; set; }
        public string spectrum_beitrag_kateogrie { get; set; }
        public bool spectrum_kategorie_beschreibung { get; set; }
    }

}
