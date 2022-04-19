using System;

namespace _0007._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int counter = 0;
            
            for (char i = '#'; i <= '7'; i++)
            {
                for (char j = '@'; j <= '`'; j++)
                {
                    for (int k = 1; k <= a; k++)
                    {
                        for (int m = 1; m <= b; m++)
                        {
                            counter++;
                            
                            if (counter <= max)
                            {
                                Console.Write($"{i}{j}{k}{m}{j}{i}");
                                Console.Write("|");
                            }
                            
                            if (counter == (a * b))
                            {
                                return;
                            }
                            j++;
                            if (j > '`')
                            {
                                j = '@';
                            }
                            i++;
                            if (i > '7')
                            {
                                i = '#';
                            }
                            continue;
                        }
                    }
                }
            }
        }
    }
}
