using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{

    public class MemberRootobject
    {
        public MemberAPI[] data { get; set; }
    }

    public class MemberAPI
    {
        public int id { get; set; }
        public string status { get; set; }
        public int? sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }

        [DataType(DataType.Html)]
        public string member_name { get; set; }
        public string member_titel { get; set; }
        public string member_potrait { get; set; }

        [DataType(DataType.Html)]
        public string member_steckbrief { get; set; }

        [DataType(DataType.Html)]
        public string member_biografie { get; set; }
        public string[] member_rollen { get; set; }
        public string profile { get; set; }
        public object[] comm_links { get; set; }
    }

    public class Biografien
    {

    }
}
