using System;

namespace _0008._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n3 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());

            int units = 0;
            int tens = 0;
            int hundreds = 0;

            for (int i = 1; i <= n3; i++)
            {
                if (i % 2 == 0)
                {
                    units += n3;
                    for (int j = 2; j <= n2; j++)
                    {
                        bool check = true;
                        int divider = 2;
                        int dividerMax = (int)Math.Sqrt(j);

                        while (check && (divider <= dividerMax))
                        {
                            if (j % divider == 0)
                            {
                                check = false;
                            }
                            divider++;
                        }
                        if (check)
                        {
                            tens += n2;
                            for (int k = 1; k <= n1; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    hundreds += n1;
                                    Console.WriteLine($"{i} {j} {k}");
                                }
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
