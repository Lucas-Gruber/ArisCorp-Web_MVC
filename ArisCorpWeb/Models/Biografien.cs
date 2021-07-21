using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class Biografien
    {
        //Biografie Seite
        [ForeignKey("BiografienId")]

        [DataType(DataType.Html)]
        public string Id { get; set; }
        public string Mitglied { get; set; }
        public string Titel { get; set; }

        [DataType(DataType.Html)]
        public string Steckbrief { get; set; }

        [DataType(DataType.Html)]
        public string Bio { get; set; }

        [DataType(DataType.Html)]
        public string Zusatz { get; set; }

        //Biografie Homepage
        public string HomepageRolle { get; set; }
    }


    public class BioRootobject
    {
        public BiografienAPI data { get; set; }
    }

    public class BiografienAPI
    {
        public string name { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public string user_updated { get; set; }
        public DateTime date_updated { get; set; }
        public string titel { get; set; }
        public string steckbrief { get; set; }
        public string bio { get; set; }
        public bool mitglied { get; set; }
        public bool rekrutierung { get; set; }
        public bool marketing_und_presse { get; set; }
        public string potrait { get; set; }
    }


    public class BioIndexRootobject
    {
        public BiografienIndexAPI[] data { get; set; }
    }
    public class BiografienIndexAPI
    {
        public string name { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public string user_updated { get; set; }
        public DateTime date_updated { get; set; }
        public string titel { get; set; }
        public string steckbrief { get; set; }
        public string bio { get; set; }
        public bool mitglied { get; set; }
        public bool rekrutierung { get; set; }
        public bool marketing_und_presse { get; set; }
        public string potrait { get; set; }
    }

}
