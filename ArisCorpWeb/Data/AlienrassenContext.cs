using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Data
{
    public class AlienrassenContext : DbContext
    {
        public AlienrassenContext(DbContextOptions<AlienrassenContext> options)
            : base(options)
        {
        }

        public DbSet<Alienrassen> Alienrassen { get; set; }
    }
}
