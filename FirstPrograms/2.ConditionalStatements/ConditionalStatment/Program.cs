using System;

namespace ConditionalStatment
{
    class Program
    {
        static void Main(string[] args)
        {
            string awit = Console.ReadLine();
            switch (awit)
            {
                case "monday":
                    Console.WriteLine("monday");
                    break;
                case "SUNDAY":
                    Console.WriteLine("SUNDAY");
                    break;
                case "satarday":
                    Console.WriteLine("satarday");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine("Hello World!");
        }
    }
}
