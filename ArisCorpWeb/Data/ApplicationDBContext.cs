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
        public DbSet<Systeme> Systeme { get; set; }
        public DbSet<Technologien> Technologien { get; set; }
        public DbSet<Firmen> Firmen { get; set; }
        public DbSet<Gameplays> Gameplays { get; set; }
    }
}
