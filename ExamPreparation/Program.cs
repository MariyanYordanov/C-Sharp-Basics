using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double counterStudent = 0;
            double counterStandard = 0;
            double counterKid = 0;
            double counterTotal = 0;
            while (movie != "Finish")
            {
                double seats = double.Parse(Console.ReadLine());
                string typeTicket = Console.ReadLine();
                double counterSeats = 0;

                while (typeTicket != "End")
                {
                    if (typeTicket == "student")
                    {
                        counterStudent++;
                    }
                    if (typeTicket == "standard")
                    {
                        counterStandard++;
                    }
                    if (typeTicket == "kid")
                    {
                        counterKid++;
                    }
                    counterSeats++;
                    counterTotal++;
                    if (counterSeats >= seats)
                    {
                        break;
                    }
                    
                    typeTicket = Console.ReadLine();
                }

                double porcentHall = counterSeats / seats * 100;
                Console.WriteLine($"{movie} - {porcentHall:f2}% full.");
                movie = Console.ReadLine();
                
            }
            double porcentStudent = counterStudent / counterTotal * 100;
            double porcentStandard = counterStandard / counterTotal * 100;
            double porcentKid = counterKid / counterTotal * 100;
            Console.WriteLine($"Total tickets: {counterTotal}");
            Console.WriteLine($"{porcentStudent:f2}% student tickets.");
            Console.WriteLine($"{porcentStandard:f2}% standard tickets.");
            Console.WriteLine($"{porcentKid:f2}% kids tickets.");
        }
    }
}

