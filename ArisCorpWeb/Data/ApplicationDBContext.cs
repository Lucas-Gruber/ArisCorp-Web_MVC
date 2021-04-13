using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Models;
using ArisCorpWeb.Data;

namespace ArisCorpWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Biografien> Biografien { get; set; }
        public DbSet<Alienrassen> Alienrassen { get; set; }
        public DbSet<Biestarium> Biestarium { get; set; }
        public DbSet<Pflanzen> Pflanzen { get; set; }
        public DbSet<Systeme> Systeme { get; set; }
        public DbSet<Technologien> Technologien { get; set; }
        public DbSet<Gameplays> Gameplays { get; set; }


        public DbSet<Firmen_Dienstleister> Firmen_Dienstleister { get; set; }
        public DbSet<Firmen_Geschäfte> Firmen_Geschäfte { get; set; }
        public DbSet<Firmen_Organisationen> Firmen_Organisationen { get; set; }
        public DbSet<Firmen_Verschiedenes> Firmen_Verschiedenes { get; set; }

        public DbSet<Firmen_Hersteller_Raumschiffe> Firmen_Hersteller_Raumschiffe { get; set; }
        public DbSet<Firmen_Hersteller_Komponenten> Firmen_Hersteller_Komponenten { get; set; }
        public DbSet<Firmen_Hersteller_Waffen> Firmen_Hersteller_Waffen { get; set; }
        public DbSet<Firmen_Hersteller_Personenausrüstung> Firmen_Hersteller_Personenausrüstung { get; set; }
    }
}
