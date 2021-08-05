using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class CreditsRootobject
    {
        public CreditsAPI data { get; set; }
    }

    public class CreditsAPI
    {
        public int id { get; set; }
        public string status { get; set; }
        public string credits { get; set; }
    }

}
