using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class Firmen_Verschiedenes
    {
        [DataType(DataType.Html)]
        public string Id { get; set; }
        public string Firma { get; set; }

        [DataType(DataType.Html)]
        public string PictureEinleitung { get; set; }
        [DataType(DataType.Html)]
        public string Einleitung { get; set; }

        
        [DataType(DataType.Html)]
        public string PictureContent { get; set; }
        [DataType(DataType.Html)]
        public string Content { get; set; }
    }
}
