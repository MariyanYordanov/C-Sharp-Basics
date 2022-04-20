using System;

namespace _005Coins2
{
    class Program
    {
        static void Main(string[] args)
        {
            string change = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < change.Length; i++)
            {
                char number = change[i];

                if (number == '1' || number == '2' || number == '5')
                {
                    counter += 1;
                }
                if (number == '3' || number == '4' || number == '6' || number == '7')
                {
                    counter += 2;
                }
                if (number == '8' || number == '9')
                {
                    counter += 3;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
