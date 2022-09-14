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
           
            base.OnModelCreating(builder);
        }
    }
}