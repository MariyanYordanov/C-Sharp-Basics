using System;

namespace _06._Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFirst = Console.ReadLine();
            string nameLast = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {nameFirst} {nameLast}, a {age}-years old person from {town}.");
        }
    }
}
