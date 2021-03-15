using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Data
{
    public class BiografienContext : DbContext
    {
        public BiografienContext(DbContextOptions<BiografienContext> options)
            : base(options)
        {
        }

        public DbSet<Biografien> Biografien { get; set; }
    }
}
