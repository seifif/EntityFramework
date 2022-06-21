using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class DrivingDbContext: DbContext
    {
        public DrivingDbContext(DbContextOptions<DrivingDbContext> options) : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().ToTable("drivers");
            modelBuilder.Entity<Car>().ToTable("cars");
        }
    }
}
