using System;

namespace _001._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            bool check = false;
            int counter = 0;
            while (favoriteBook != "No More Books")
            {
                string book = Console.ReadLine();
                if (book == "No More Books")
                {
                    check = false;
                    break;
                }
                if (book == favoriteBook)
                {
                    check = true;
                    break;
                }
                counter++;
            }
            if (check)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
