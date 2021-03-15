using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArisCorpWeb.Models;

namespace ArisCorpWeb.Data
{
    public class SystemeContext : DbContext
    {
        public SystemeContext(DbContextOptions<SystemeContext> options)
            : base(options)
        {
        }

        public DbSet<Systeme> Systeme { get; set; }
    }
}
