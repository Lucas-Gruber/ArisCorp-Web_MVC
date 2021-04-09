using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{
    public class Firmen
    {
        public IEnumerable<Firmen_Hersteller_Raumschiffe> hersteller_raumschiffe { get; set; }
        public IEnumerable<Firmen_Hersteller_Komponenten> hersteller_komponenten { get; set; }
        public IEnumerable<Firmen_Hersteller_Waffen> hersteller_waffen { get; set; }
        public IEnumerable<Firmen_Hersteller_Personenausrüstung> hersteller_personenausrüstung { get; set; }
        public IEnumerable<Firmen_Dienstleister> dienstleister { get; set; }
        public IEnumerable<Firmen_Geschäfte> geschäfte { get; set; }
        public IEnumerable<Firmen_Organisationen> organisationen { get; set; }
        public IEnumerable<Firmen_Verschiedenes> verschiedenes { get; set; }
    }
}
