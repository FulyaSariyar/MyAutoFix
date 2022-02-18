using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyAutoFix.Models.Entities;
using MyAutoFix.Models.Identity;

namespace MyAutoFix.Data
{
    public class MyContext : IdentityDbContext<ApplicationUser, AplicationRole, string>//varsayılan ıd tipi string guid
    {
        public MyContext(DbContextOptions<MyContext> options)
          : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ServiceProduct>()
                .Property(x => x.Price)
                .HasPrecision(7, 2);
        }

        public DbSet<ServiceProduct> ServiceProducts { get; set; }
        public DbSet<FailureLogging> FailureLoggings { get; set; }
        public DbSet<CartItem> ShoppingCarts { get; set; }
    }
}
