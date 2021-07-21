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
        public GeschichteAPI data { get; set; }
    }

    public class GeschichteAPI
    {
        public string name { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public string user_updated { get; set; }
        public DateTime? date_updated { get; set; }
        public string text { get; set; }
    }

}
