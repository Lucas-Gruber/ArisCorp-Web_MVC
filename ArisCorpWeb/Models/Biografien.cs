using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class Biografien
    {
        //Biografie Seite
        public string Id { get; set; }
        public string Mitglied { get; set; }
        public string Titel { get; set; }
        public string Potrait { get; set; }

        [DataType(DataType.Html)]
        public string Content1 { get; set; }

        [DataType(DataType.Html)]
        public string Content2 { get; set; }

        [DataType(DataType.Html)]
        public string Content3 { get; set; }

        [DataType(DataType.Html)]
        public string Content4 { get; set; }

        //Biografie Homepage
        public string HomepageName { get; set; }
        public string HomepageRolle { get; set; }

        [DataType(DataType.Html)]
        public string Link { get; set; }
    }
}
