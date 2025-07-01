using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking
{
    public class movies
    {
        public string _MovieName { get; private set; }
        public string _ActorName;
        public string _ActressName;
        public string _Direcotr;
        public string _Producer;
        public double _Price;
        public double _Duration;
        public static List<movies> moviesList = new List<movies>();

        // Constructor to fix CS1729 error  
        public movies(string movieName, string actorName, string actressName, string director, string producer, double price, double duration)
        {
            _MovieName = movieName;
            _ActorName = actorName;
            _ActressName = actressName;
            _Direcotr = director;
            _Producer = producer;
            _Price = price;
            _Duration = duration;
        }

        // Method to add movie to list  
        public void AddMovieToList()
        {
            moviesList.Add(this);
        }

        // Method to retrieve all movies  
        public static List<movies> GetMovies()
        {
            return moviesList;
        }
    }
}
