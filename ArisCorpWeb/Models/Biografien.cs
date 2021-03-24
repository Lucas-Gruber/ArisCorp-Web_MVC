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

        [DataType(DataType.Html)]
        public string Link { get; set; }
    }
}
