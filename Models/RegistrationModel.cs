using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Ime mora biti upisano.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Prezime mora biti upisano.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "E-mail mora biti upisan.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Lozinka mora biti upisana.")]
        [MinLength(6, ErrorMessage = "Lozinka mora sadržavati minimalno 6 znakova.")]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Lozinka i potvrda lozinke nisu iste.")]
        public string? ConfirmPassword { get; set; }
    }
}
