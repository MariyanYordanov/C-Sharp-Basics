using System;

namespace _02Nomber1to10
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double santimeters = inches * 2.54;

            Console.WriteLine(santimeters);
        }
    }
}
