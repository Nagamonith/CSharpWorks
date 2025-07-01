using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking
{
    public class ticket
    {
        public ticket(int movieIndex, int theaterIndex)
        {
            List<movies> movies = Ticket_Booking.movies.GetMovies();
            List<thearter> theaters = thearter.thearteeList;

            
            if (movieIndex < 0 || movieIndex >= movies.Count || theaterIndex < 0 || theaterIndex >= theaters.Count)
            {
                Console.WriteLine("❌ Invalid movie or theater index.");
                return;
            }

            Console.WriteLine($"===================================================================");
            Console.WriteLine($"|| {customers._CustomerName}, your ticket has been booked!||");
            Console.WriteLine($"|| Movie: {movies[movieIndex]._MovieName}||");
            Console.WriteLine($"|| Hero: {movies[movieIndex]._ActorName}||");
            Console.WriteLine($"|| Theater: {theaters[theaterIndex]._ThearterName}||"); // Fixed by qualifying with the type name
            Console.WriteLine($" ||Price: ₹{movies[movieIndex]._Price}||");
            Console.WriteLine($"===================================================================");
        }
    }
}