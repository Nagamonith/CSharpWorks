using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Ticket_Booking
{
    public class thearter
    {
       public string _ThearterName ,Location; 
         string _CurrShow, _NextShow;
        double avaliable_seat, empty_seat;
        public int opted;

        List<movies> movies = Ticket_Booking.movies.GetMovies();
        public static List<thearter> thearteeList = new List<thearter>();

        public thearter(string thearterName, string location, double avaliable_seat, double empty_seat)
        {
            _ThearterName = thearterName;
            Location = location;

            this.avaliable_seat = avaliable_seat;
            this.empty_seat = empty_seat;
        }

        public static void addthreater(thearter newThearter)
        {
            thearteeList.Add(newThearter);
        }

        public void showshows()
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($" {movies[i]._MovieName} Hero {movies[i]._ActorName} Price {movies[i]._Price} Duration {movies[0]._Duration}");
            }
            int opt = Convert.ToInt32(Console.ReadLine());
            opted = opt;
        }
    }
}
