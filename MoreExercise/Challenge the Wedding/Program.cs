using System;

namespace _0005._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int table = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= men;i++)
            {
                for (int j = 1; j <= women;j++)
                {
                        counter++;
                    if (table >= counter)
                    {
                        Console.Write($"({i} <-> {j})" + " ");
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}

