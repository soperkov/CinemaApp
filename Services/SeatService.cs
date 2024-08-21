using CinemaApp.Models;

namespace CinemaApp.Services
{
    public class SeatService
    {
        private readonly AppDbContext _context;

        public SeatService(AppDbContext context)
        {
            _context = context;
        }

        //Method for filling a DB. Use only first time
        //public void LoadSeats()
        //{
        //    int nSeats = 50;
        //    for (int i = 0;  i < nSeats; i++)
        //    {
        //        int round = i / 10;
        //        switch(round)
        //        {
        //            case 0:
        //                SeatsModel model = new SeatsModel()
        //                {
        //                    Row = 'A',
        //                    Position = i % 10,
        //                };
        //                _context.Seats.Add(model);
        //                _context.SaveChanges();
        //                continue;
        //            case 1:
        //                model = new SeatsModel()
        //                {
        //                    Row = 'B',
        //                    Position = i % 10,
        //                };
        //                _context.Seats.Add(model);
        //                _context.SaveChanges();
        //                continue;
        //            case 2:
        //                model = new SeatsModel()
        //                {
        //                    Row = 'C',
        //                    Position = i % 10,
        //                };
        //                _context.Seats.Add(model);
        //                _context.SaveChanges();
        //                continue;
        //            case 3:
        //                model = new SeatsModel()
        //                {
        //                    Row = 'D',
        //                    Position = i % 10,
        //                };
        //                _context.Seats.Add(model);
        //                _context.SaveChanges();
        //                continue;
        //            case 4:
        //                model = new SeatsModel()
        //                {
        //                    Row = 'E',
        //                    Position = i % 10,
        //                };
        //                _context.Seats.Add(model);
        //                _context.SaveChanges();
        //                continue;
        //            case 5:
        //                model = new SeatsModel()
        //                {
        //                    Row = 'F',
        //                    Position = i % 10,
        //                };
        //                _context.Seats.Add(model);
        //                _context.SaveChanges();
        //                continue;
        //        }
        //    }
        //}

        public SeatsModel GetSeatsModel(int id) 
        {
            return _context.Seats.FirstOrDefault(i => i.Id == id);
        }

        public string GetSeatName(int id)
        {
            var seatName = "";
            seatName += _context.Seats.FirstOrDefault(i => i.Id == id).Row.ToString();
            seatName += _context.Seats.FirstOrDefault(i => i.Id == id).Position.ToString();
            return seatName;
        }

        public List<SeatsModel> GetSeats()
        {
            return _context.Seats.ToList();
        }
    }
}
