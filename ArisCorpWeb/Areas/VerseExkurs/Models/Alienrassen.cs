using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class Alienrassen
    {
        public string Id { get; set; }
        public string Rasse { get; set; }

        [DataType(DataType.Html)]
        public string PictureEinleitung { get; set; }

        [DataType(DataType.Html)]
        public string PictureGeschichte { get; set; }

        [DataType(DataType.Html)]
        public string PictureHeimatwelt { get; set; }

        [DataType(DataType.Html)]
        public string PicturePolitik { get; set; }

        [DataType(DataType.Html)]
        public string PictureDiplomatie { get; set; }

        [DataType(DataType.Html)]
        public string PictureSprache { get; set; }

        [DataType(DataType.Html)]
        public string PictureReligion { get; set; }

        [DataType(DataType.Html)]
        public string PictureMilitar { get; set; }

        [DataType(DataType.Html)]
        public string PictureKriminalitat { get; set; }

        [DataType(DataType.Html)]
        public string PictureKultur { get; set; }

        [DataType(DataType.Html)]
        public string PictureBesuch { get; set; }

        [DataType(DataType.Html)]
        public string PictureSicherheit { get; set; }

        [DataType(DataType.Html)]
        public string Einleitung { get; set; }

        [DataType(DataType.Html)]
        public string Geschichte { get; set; }

        [DataType(DataType.Html)]
        public string Heimatwelt { get; set; }

        [DataType(DataType.Html)]
        public string Politik { get; set; }

        [DataType(DataType.Html)]
        public string Diplomatie { get; set; }

        [DataType(DataType.Html)]
        public string Sprache { get; set; }

        [DataType(DataType.Html)]
        public string Religion { get; set; }

        [DataType(DataType.Html)]
        public string Militar { get; set; }

        [DataType(DataType.Html)]
        public string Kriminalitat { get; set; }

        [DataType(DataType.Html)]
        public string Kultur { get; set; }

        [DataType(DataType.Html)]
        public string Besuch { get; set; }

        [DataType(DataType.Html)]
        public string Sicherheit { get; set; }
    }
}
