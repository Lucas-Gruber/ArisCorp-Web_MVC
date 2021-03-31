using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArisCorpWeb.Data
{
    public class IdentityDBContext : IdentityDbContext
    {
        public IdentityDBContext(DbContextOptions<IdentityDBContext> options)
        : base(options)
        {

        }

        public DbSet<RoleMenuPermission> RoleMenuPermission { get; set; }

        public DbSet<NavigationMenu> NavigationMenu { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RoleMenuPermission>()
            .HasKey(c => new { c.RoleId, c.NavigationMenuId });


            base.OnModelCreating(builder);
        }
    }
}
