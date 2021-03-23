using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class HomeDB
    {
        public string Id { get; set; }

        [DataType(DataType.Html)]
        public string About { get; set; }

        [DataType(DataType.Html)]
        public string History { get; set; }

        [DataType(DataType.Html)]
        public string Manifest { get; set; }

        [DataType(DataType.Html)]
        public string Charter { get; set; }

        [DataType(DataType.Html)]
        public string Member { get; set; }

        [DataType(DataType.Html)]
        public string Fleet { get; set; }

        [DataType(DataType.Html)]
        public string Partner { get; set; }
    }
}
