using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {


            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();


            if (inputUnit == "mm")
            {
                number = number / 1000;
            }
            else if (inputUnit == "cm")
            {
                number = number / 100;
            }



            if (outputUnit == "mm")
            {
                number = number * 1000;
            }
            else if (outputUnit == "cm")
            {
                number = number * 100;
            }

            Console.WriteLine($"{number:f3}");
        }
    }
}
