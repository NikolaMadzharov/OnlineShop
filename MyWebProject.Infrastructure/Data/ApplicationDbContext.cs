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
        public DbSet<CaseModel> CaseModels { get; set; }
        public DbSet<ProtectorModel> ProtectedModels { get; set; }
        public DbSet<PhoneModel> PhoneModels { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Mobilephone>().HasOne(m => m.PhoneModel).WithMany(m => m.PhoneModels)
                .HasForeignKey(m => m.MobilephoneModelId).OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<Case>().HasOne(m => m.CaseModel).WithMany(m => m.Cases)
            //    .HasForeignKey(m => m.CaseModelId).OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<Case>().HasOne(m => m.CaseModel).WithMany(m => m.Cases)
            //    .HasForeignKey(m => m.CaseModelId).OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}