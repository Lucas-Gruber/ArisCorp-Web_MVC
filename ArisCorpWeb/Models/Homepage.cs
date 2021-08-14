using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArisCorpWeb.Models
{

    public class HomeRootobject
    {
        public HomeAPI data { get; set; }
    }

    public class HomeAPI
    {
        public int id { get; set; }
        public string status { get; set; }
        public About_Ariscorp about_ariscorp { get; set; }
        public Ariscorp_History ariscorp_history { get; set; }
        public Ariscorp_Manifest ariscorp_manifest { get; set; }
        public Ariscorp_Charta ariscorp_charta { get; set; }
        public Ariscorp_Partner[] ariscorp_partner { get; set; }
        public Ariscorp_Gameplays[] ariscorp_gameplays { get; set; }
        public Ariscorp_Mitglieder[] ariscorp_mitglieder { get; set; }
        public Ariscorp_Comm_Links[] ariscorp_comm_links { get; set; }
    }

    public class About_Ariscorp
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public string user_updated { get; set; }
        public DateTime date_updated { get; set; }
        public string about_ariscorp { get; set; }
    }

    public class Ariscorp_History
    {
        public int id { get; set; }
        public string status { get; set; }
        public DateTime date_updated { get; set; }
        public string ariscorp_history { get; set; }
    }

    public class Ariscorp_Manifest
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public string user_created { get; set; }
        public DateTime date_created { get; set; }
        public string user_updated { get; set; }
        public DateTime date_updated { get; set; }
        public string manifest { get; set; }
    }

    public class Ariscorp_Charta
    {
        public int id { get; set; }
        public string status { get; set; }
        public object sort { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }
        public string charta { get; set; }
    }

    public class Ariscorp_Partner
    {
        public int id { get; set; }
        public string status { get; set; }
        public int sort { get; set; }
        public string date_created { get; set; }
        public string partner_logo { get; set; }
        public string partner_name { get; set; }
        public string partner_website { get; set; }
    }

    public class Ariscorp_Gameplays
    {
        public int id { get; set; }
        public string status { get; set; }
        public int sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }
        public string gameplay_logo { get; set; }
        public string gameplay_bild_links { get; set; }
        public string gameplay_bild_rechts { get; set; }
        public string gameplay_text { get; set; }
        public string gameplay_name { get; set; }
    }

    public class Ariscorp_Mitglieder
    {
        public int id { get; set; }
        public string status { get; set; }
        public int sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }
        public string member_name { get; set; }
        public string member_titel { get; set; }
        public string member_potrait { get; set; }
        public string member_steckbrief { get; set; }
        public string member_biografie { get; set; }
        public string[] member_rollen { get; set; }
        public string profile { get; set; }
        public int?[] comm_links { get; set; }
    }

    public class Ariscorp_Comm_Links
    {
        public int id { get; set; }
        public string status { get; set; }
        public int sort { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }
        public string comm_link_titel { get; set; }
        public string comm_link_banner { get; set; }
        public int comm_link_author { get; set; }
        public string comm_link { get; set; }
        public home_Comm_Link_Channel comm_link_channel { get; set; }
        public object comm_link_beschreibung { get; set; }
    }

    public class home_Comm_Link_Channel
    {
        public string channel { get; set; }
    }

}
