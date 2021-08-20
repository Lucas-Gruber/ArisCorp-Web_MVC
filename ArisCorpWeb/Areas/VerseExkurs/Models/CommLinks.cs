using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{

    public class CommLinksRootobject
    {
        public CommLinksAPI[] data { get; set; }
    }

    public class CommLinksAPI
    {
        public int id { get; set; }
        public string status { get; set; }
        public int? sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }
        public string comm_link_titel { get; set; }
        public string comm_link_banner { get; set; }
        public int comm_link_author { get; set; }
        public string comm_link { get; set; }
        public Comm_Link_Channel comm_link_channel { get; set; }
        public object comm_link_beschreibung { get; set; }
    }

    public class Comm_Link_Channel
    {
        public string channel { get; set; }
    }
}
