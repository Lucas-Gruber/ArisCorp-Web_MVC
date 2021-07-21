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

    public class GameplayRootobject
    {
        public GameplaysAPI[] data { get; set; }
    }

    public class GameplaysAPI
    {
        public string gameplay { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public object user_updated { get; set; }
        public object date_updated { get; set; }
        public string beschreibung { get; set; }
    }
}
