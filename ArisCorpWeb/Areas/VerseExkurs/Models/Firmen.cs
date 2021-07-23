using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class FirmenRootobject
    {
        public FirmenAPI[] data { get; set; }
    }

    public class FirmenAPI
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }
        public string firmen_banner { get; set; }
        public string firmen_trans_logo { get; set; }
        public string firmen_text { get; set; }
        public string firmenkategorie { get; set; }
        public string firmen_name { get; set; }
    }

}
