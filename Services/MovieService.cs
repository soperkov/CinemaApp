using CinemaApp.Models;

namespace CinemaApp.Services
{
    public class MovieService
    {
        private readonly AppDbContext _context;
        public MovieService(AppDbContext context) { _context = context; }

        public double GetPrice (string name)
        {
            return _context.Movies.FirstOrDefault(s => s.Title == name).Price;
        }

        public int GetId (string name)
        {
            return _context.Movies.FirstOrDefault(s => s.Title == name).Id;
        }

        public MovieModel GetMovieModel(string name) 
        {
            return _context.Movies.FirstOrDefault(s => s.Title == name);
        }


    }
}
