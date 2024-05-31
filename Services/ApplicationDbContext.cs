using J104895_CO5227_ver3.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace J104895_CO5227_ver3.Services
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Dish> Menu { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var client = new IdentityRole("client");
            admin.NormalizedName = "client";

            var seller = new IdentityRole("seller");
            admin.NormalizedName = "seller";

            builder.Entity<IdentityRole>().HasData(admin, client, seller);

            // Configure precision and scale for the Price property
            builder.Entity<Dish>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18, 2)");
        }
    }
}
