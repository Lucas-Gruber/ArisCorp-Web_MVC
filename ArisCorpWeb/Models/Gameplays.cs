using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class Gameplays
    {
        public int Id { get; set; }
        public string Gameplay { get; set; }
        public string Description { get; set; }
    }
}
