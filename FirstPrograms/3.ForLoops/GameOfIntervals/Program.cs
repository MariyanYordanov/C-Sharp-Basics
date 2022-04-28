using System;

namespace _0005._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double moves = int.Parse(Console.ReadLine());

            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;
            double count5 = 0;
            double count6 = 0;
            double result = 0;

            for (int i = 0; i < moves; i++)
            {
                double number = double.Parse(Console.ReadLine());
                
                if (number >= 0 && number <= 9)
                {
                    result += number * 0.2;
                    count1++;
                }
                if (number >= 10 && number <= 19)
                {
                    result += number * 0.3;
                    count2++;
                }
                if (number >= 20 && number <= 29)
                {
                    result += number * 0.4;
                    count3++;
                }
                if (number >= 30 && number <= 39)
                {
                    result += 50;
                    count4++;
                }
                if (number >= 40 && number <= 50)
                {
                    result += 100;
                    count5++;
                }
                if (number < 0 || number > 50)
                {
                    result /= 2;
                    count6++;
                }
            }

            double first = count1 / moves * 100;
            double second = count2 / moves * 100;
            double third = count3 / moves * 100;
            double forth = count4 / moves * 100;
            double fifth = count5 / moves * 100;
            double sixth = count6 / moves * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {(first):f2}%");
            Console.WriteLine($"From 10 to 19: {(second):f2}%");
            Console.WriteLine($"From 20 to 29: {(third):f2}%");
            Console.WriteLine($"From 30 to 39: {(forth):f2}%");
            Console.WriteLine($"From 40 to 50: {(fifth):f2}%");
            Console.WriteLine($"Invalid numbers: {(sixth):f2}%");
        }
    }
}
