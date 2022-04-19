using System;

namespace _0012._The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int control = int.Parse(Console.ReadLine());
            bool check = false;
            int counter = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d && ((a * b) + (c * d) == control))
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (counter == 4)
                                {
                                    check = true;
                                    one = a;
                                    two = b;
                                    three = c;
                                    four = d;
                                }
                            }

                        }
                    }
                }
            }
            if (check)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {one}{two}{three}{four}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"No!");
            }

        }
    }
}
