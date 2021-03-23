using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Data
{
    public class HomeDBContext : DbContext
    {
        public HomeDBContext(DbContextOptions<HomeDBContext> options)
            : base(options)
        {
        }

        public DbSet<HomeDB> Home { get; set; }
    }
}
