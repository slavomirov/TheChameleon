using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using TheChameleon.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace TheChameleon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Extra> Extras { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<UserCar> UserCars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Car>().ToTable("Cars");
            builder.Entity<Extra>().ToTable("Extras");
            builder.Entity<Image>().ToTable("Images");
            builder.Entity<UserCar>().ToTable("UserCars");

            //builder.Entity<Car>().HasKey(x => x.Id);
            //builder.Entity<Extra>().HasKey(x => x.Id);
            //builder.Entity<Image>().HasKey(x => x.Id);
            //builder.Entity<UserCar>().HasKey(x => x.Id);
        }

    }
}
