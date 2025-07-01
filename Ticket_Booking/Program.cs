using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking
{
    internal class Program
    {
        static void Main()
        {
            bool stay = true;

            while (stay)
            {
                Console.WriteLine($"============menu=====");
                Console.WriteLine($"Press 1 to add movies");
                Console.WriteLine($"Press 2 to add theater");
                Console.WriteLine($"Press 3 to add customer");
                Console.WriteLine($"Press 4 to exit");
                int create = Convert.ToInt32(Console.ReadLine());
                switch (create)
                {
                    case 1:
                        Console.WriteLine(" Add New Movie:");

                        Console.Write("Enter Movie Name: ");
                        string movieName = Console.ReadLine();

                        Console.Write("Enter Actor Name: ");
                        string actorName = Console.ReadLine();

                        Console.Write("Enter Actress Name: ");
                        string actressName = Console.ReadLine();

                        Console.Write("Enter Director Name: ");
                        string director = Console.ReadLine();

                        Console.Write("Enter Producer Name: ");
                        string producer = Console.ReadLine();

                        Console.Write("Enter Ticket Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Duration (in hours): ");
                        double duration = Convert.ToDouble(Console.ReadLine());

                        movies m = new movies(movieName, actorName, actressName, director, producer, price, duration);
                        m.AddMovieToList();

                        Console.WriteLine(" Movie added successfully!");
                        break;

                    case 2:
                        Console.WriteLine(" Add New Theater:");

                        Console.Write("Enter Theater Name: ");
                        string theaterName = Console.ReadLine();

                        Console.Write("Enter Location: ");
                        string location = Console.ReadLine();

                        Console.Write("Enter Available Seats: ");
                        double availableSeats = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Empty Seats: ");
                        double emptySeats = Convert.ToDouble(Console.ReadLine());

                        thearter t = new thearter(theaterName, location, availableSeats, emptySeats);
                        thearter.addthreater(t);

                        Console.WriteLine(" Theater added successfully!");
                        break;

                    case 3:
                        Console.WriteLine(" Add New Customer");

                        Console.Write("Enter Customer Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        double age = Convert.ToDouble(Console.ReadLine());

                        customers c1 = new customers(name, age);

                        Console.WriteLine($" Welcome, {customers._CustomerName}!");
                        break;
                    case 4:
                        stay = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            bool select = true;

            while (select)
            {
                Console.WriteLine("\n=== Ticket Booking Menu ===");
                Console.WriteLine("Press 1 to see movies");
                Console.WriteLine("Press 2 to see theater");
                Console.WriteLine("Press 3 to book ticket");
                Console.WriteLine("Press 4 to exit");

                Console.Write("Enter your choice: ");
                int opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine(" Available Movies:");
                        List<movies> movieList = movies.GetMovies();

                        for (int i = 0; i < movieList.Count; i++)
                        {
                            Console.WriteLine($"[{i}] {movieList[i]._MovieName} - Hero: {movieList[i]._ActorName}, ₹{movieList[i]._Price}");
                        }
                        break;

                    case 2:
                        Console.WriteLine(" Available Theaters:");
                        List<thearter> theaterList = thearter.thearteeList;

                        for (int i = 0; i < theaterList.Count; i++)
                        {
                            Console.WriteLine($"[{i}] {theaterList[i]._ThearterName} - Location: {theaterList[i].Location}");
                        }
                        break;

                    case 3:
                        Console.Write("Select movie index: ");
                        int movieIndex = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Select theater index: ");
                        int theaterIndex = Convert.ToInt32(Console.ReadLine());

                        ticket t = new ticket(movieIndex, theaterIndex);

                        break;

                    case 4:
                        Console.WriteLine(" Exiting... Thank you!");
                        select = false;
                        break;

                    default:
                        Console.WriteLine(" Invalid selection. Try again.");
                        break;
                }
            }
        }
    }
    }

