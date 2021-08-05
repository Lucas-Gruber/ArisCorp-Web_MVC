using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class GameplaysRootobject
    {
        public GameplaysAPI[] data { get; set; }
    }

    public class GameplaysAPI
    {
        public int id { get; set; }
        public string status { get; set; }
        public int sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }
        public string gameplay_logo { get; set; }
        public string gameplay_bild_links { get; set; }
        public string gameplay_bild_rechts { get; set; }
        public string gameplay_text { get; set; }
        public string gameplay_name { get; set; }
    }

}
