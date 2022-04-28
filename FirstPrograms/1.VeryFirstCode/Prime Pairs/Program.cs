using System;

namespace _0013._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startFirst = int.Parse(Console.ReadLine());
            int startSecond = int.Parse(Console.ReadLine());
            int diffFirst = int.Parse(Console.ReadLine());
            int diffSecond = int.Parse(Console.ReadLine());

            int finnalFirst = startFirst + diffFirst;
            int finnalSecond = startSecond + diffSecond;

            for (int i = startFirst; i <= finnalFirst; i++)
            {
                
                for (int j = startSecond; j <= finnalSecond; j++)
                {
                    
                    bool check = true;
                    int divider = 2;
                    int dividerMax = (int)Math.Sqrt(i);

                    bool check1 = true;
                    int divider1 = 2;
                    int dividerMax1 = (int)Math.Sqrt(j);

                    while (check && (divider <= dividerMax))
                    {
                        if (i % divider == 0)
                        {
                            check = false;
                        }
                        divider++;
                    }
                    
                    while (check1 && (divider1 <= dividerMax1))
                    {
                        if (j % divider1 == 0)
                        {
                            check1 = false;
                        }
                        divider1++;
                    }
                    if (check1 == true && check == true)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }
    }
}
