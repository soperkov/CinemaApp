using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models
{
    public class MovieModel
    {
        [Key]public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public int TotalSeats { get; set; }
    }
}
