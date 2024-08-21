using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models
{
    public class SeatsModel
    {
        [Key]public int Id { get; set; }
        public char Row {  get; set; }
        public int Position { get; set; }
    }
}
