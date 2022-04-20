using System;

namespace _0006._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowInSector = int.Parse(Console.ReadLine());
            int seatsSectorOdd = int.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = 'A'; i <= lastSector; i++)
            {
                for (int j = 1; j <= rowInSector; j++)
                {
                    int seats = 0;
                    if (j % 2 ==0)
                    {
                        seats = seatsSectorOdd + 98;
                    }
                    else
                    {
                        seats = seatsSectorOdd + 96;
                    }
                    
                    char letter = Convert.ToChar(seats);
                    for (char k = 'a'; k <= letter; k++)
                    {
                        counter++;
                        Console.WriteLine($"{i}{j}{k}");
                    }
                    
                }
                rowInSector++;
            }
            Console.WriteLine(counter);
        }
    }
}
