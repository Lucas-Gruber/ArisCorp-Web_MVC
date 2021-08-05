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
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }
        public string literatur_author { get; set; }
        public string literatur_protagonist { get; set; }
        public string literatur_cover { get; set; }
        public string literatur_titel { get; set; }
        public int literatur_kapitel { get; set; }
        public string literatur_text { get; set; }
    }

}
