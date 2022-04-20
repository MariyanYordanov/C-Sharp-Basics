using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int max = int.MinValue;
            while (number != "Stop")
            {
               int input = int.Parse(number);

                if (input > max)
                {
                    max = input;
                }

                number = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
