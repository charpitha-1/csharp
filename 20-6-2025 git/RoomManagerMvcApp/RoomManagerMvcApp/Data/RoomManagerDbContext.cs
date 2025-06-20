
using Microsoft.EntityFrameworkCore;

namespace RoomManagerMvcApp.Data
{
    public class RoomManagerDbContext:DbContext
    {
        public DbSet<MeetingRoom> MeetingRoomSet { get; set; } 
        public DbSet<UserInfo> UserInfoSet { get; set; }
        public DbSet<Reservation> ReservationsSet { get; set; }
        public RoomManagerDbContext(DbContextOptions optionsBuilder):base(optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeetingRoom>().Property(p =>p.Capacity).HasDefaultValue(10);
            modelBuilder.Entity<MeetingRoom>().HasIndex(p=>p.RoomName).IsUnique(true);
            modelBuilder.Entity<UserInfo>().HasIndex(p => p.Email).IsUnique(true);

        }
    }
}
