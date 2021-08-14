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
        public string literatur_text { get; set; }
        public Literatur_Reihe literatur_reihe { get; set; }
        public object literatur_titel { get; set; }
        public int literatur_kapitel { get; set; }
    }

    public class Literatur_Reihe
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string reihen_author { get; set; }
        public object reihen_protagonist { get; set; }
        public string reihen_titel { get; set; }
        public int reihen_kapitel_anzahl { get; set; }
        public string reihen_cover { get; set; }
        public int[] literatur { get; set; }
    }

}
