using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyWebProject.Infrastructure.Data
{
    using MyWebProject.Infrastructure.Data.Models;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Mobilephone> Mobilephones { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Protector> Protectors { get; set; }
        public DbSet<MobileColor> MobileColors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MobileColor>().HasKey(x => new { x.ColorId, x.MobilephoneId });

            builder.Entity<MobileColor>().HasOne(x => x.Color).WithMany(x => x.MobileColors)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<MobileColor>().HasOne(x => x.Mobilephone).WithMany(x => x.MobileColors)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}