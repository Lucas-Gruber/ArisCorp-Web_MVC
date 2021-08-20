using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class GeschichteRootobject
    {
        public GeschichteAPI[] data { get; set; }
    }

    public class GeschichteAPI
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }
        public string geschichte_titel { get; set; }
        public bool geschichte_kategorie { get; set; }
        public string geschichte_auswahlbild { get; set; }
        public string geschichte_beitrag { get; set; }
        public string geschichte_beschreibung { get; set; }
        public string geschichte_datum { get; set; }
    }

}
