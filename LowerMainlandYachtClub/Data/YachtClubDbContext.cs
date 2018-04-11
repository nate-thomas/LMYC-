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
        public DbSet<Member> Members { get; set; }
        public DbSet<NonMember> NonMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Boat>().ToTable("Boat");
            modelBuilder.Entity<EmergencyContact>().ToTable("EmergencyContact");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Report>().ToTable("Report");
            modelBuilder.Entity<Document>().ToTable("Document");
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<NonMember>().ToTable("NonMember");
            modelBuilder.Entity<Member>().HasKey(c => new { c.BookingId, c.UserId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<LowerMainlandYachtClub.Models.Report> Report { get; set; }

        public DbSet<LowerMainlandYachtClub.Models.RoleViewModel> RoleViewModel { get; set; }

    }
}
