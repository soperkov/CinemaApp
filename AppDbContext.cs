using Microsoft.EntityFrameworkCore;
using CinemaApp.Models;

namespace CinemaApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<MovieModel> Movies { get; set; }

        public DbSet<SeatsModel> Seats { get; set; }

        public DbSet<ReservationModel> Reservations { get; set; }
    }
}
