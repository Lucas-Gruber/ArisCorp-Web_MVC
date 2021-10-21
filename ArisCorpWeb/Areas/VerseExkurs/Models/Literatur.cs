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
        public string reihen_author { get; set; }
        public string reihen_protagonist { get; set; }
        public string reihen_titel { get; set; }
        public int reihen_kapitel_anzahl { get; set; }
        public bool literatur_reihen_single_kapitel_bool { get; set; }
        public string text { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string reihen_cover { get; set; }
        public Literatur[] literatur { get; set; }

        public string literatur_text { get; set; }
        public int literatur_reihe { get; set; }
        public int literatur_kapitel { get; set; }
        public object literatur_titel { get; set; }
    }

    public class User_Created
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string location { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string[] tags { get; set; }
        public string avatar { get; set; }
        public string language { get; set; }
        public string theme { get; set; }
        public object tfa_secret { get; set; }
        public string status { get; set; }
        public string role { get; set; }
        public string token { get; set; }
        public DateTime last_access { get; set; }
        public string last_page { get; set; }
        public string provider { get; set; }
        public object external_identifier { get; set; }
        public int[] member { get; set; }
    }

    public class User_Updated
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string location { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string[] tags { get; set; }
        public string avatar { get; set; }
        public string language { get; set; }
        public string theme { get; set; }
        public object tfa_secret { get; set; }
        public string status { get; set; }
        public string role { get; set; }
        public string token { get; set; }
        public DateTime last_access { get; set; }
        public string last_page { get; set; }
        public string provider { get; set; }
        public object external_identifier { get; set; }
        public int[] member { get; set; }
    }

    public class Metadata
    {
    }

    public class Literatur
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }
        public string literatur_text { get; set; }
        public int literatur_reihe { get; set; }
        public int literatur_kapitel { get; set; }
        public object literatur_titel { get; set; }
    }

}
