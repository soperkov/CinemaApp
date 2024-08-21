using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models
{
    public class ReservationModel
    {
        [Key] public int Id { get; set; }
        public int UseerId { get; set; }
        public int MovieId { get; set; }
        public int SeatId { get; set; }
    }
}
