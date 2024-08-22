using CinemaApp.Models;

namespace CinemaApp.Services
{
    public class ReservationService
    {
        private readonly AppDbContext _context;

        public ReservationService (AppDbContext context)
        {
            _context = context;
        }

        public void ReserveSeat (ReservationModel reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }

        public bool IsReserved (int seatId, int movieId)
        {
            return _context.Reservations.Any(i => i.SeatId == seatId && i.MovieId == movieId);
        }
    }
}
