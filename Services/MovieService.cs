namespace CinemaApp.Services
{
    public class MovieService
    {
        private readonly AppDbContext _context;
        public MovieService(AppDbContext context) { _context = context; }

    }
}
