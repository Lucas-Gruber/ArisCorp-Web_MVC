using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class LiteraturRootobject
    {
        public LiteraturAPI[] data { get; set; }
    }

    public class LiteraturAPI
    {
        public string id { get; set; }
        public string status { get; set; }
        public DateTime date_created { get; set; }
        public string lit_fiktiver_autor { get; set; }
        public string lit_cover { get; set; }
        public string lit_geschichte { get; set; }
        public int lit_kapitel { get; set; }
        public string lit_titel { get; set; }
        public string lit_protagonist { get; set; }
    }

}
