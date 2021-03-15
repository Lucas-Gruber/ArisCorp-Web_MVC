using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Data
{
    public class TechnologienContext : DbContext
    {
        public TechnologienContext(DbContextOptions<TechnologienContext> options)
            : base(options)
        {
        }

        public DbSet<Technologien> Technologien { get; set; }
    }
}
