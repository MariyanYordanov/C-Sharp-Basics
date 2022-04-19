using System;

namespace Programming_Basics_Online_Exam___6_and_7_July_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double entrance = double.Parse(Console.ReadLine());
            double deckChair = double.Parse(Console.ReadLine());
            double umbrella = double.Parse(Console.ReadLine());

            double total = (people * entrance) + (Math.Ceiling(people * 0.75) * deckChair) + (Math.Ceiling(people * 0.5) * umbrella);
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
