using LowerMainlandYachtClub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LowerMainlandYachtClub.Data
{
    public class YachtClubDbContext : IdentityDbContext
    {
        public YachtClubDbContext(DbContextOptions<YachtClubDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ClassificationCode> ClassificationCodes { get; set; }
        public DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Boat>().ToTable("Boat");
            modelBuilder.Entity<EmergencyContact>().ToTable("EmergencyContact");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            base.OnModelCreating(modelBuilder);
        }

    }
}
