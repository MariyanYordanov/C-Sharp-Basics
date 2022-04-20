using System;

namespace _006._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int check = i;
                string num = check.ToString();
                string final = string.Empty;

                for (int j = 0; j < num.Length; j++)
                {
                    int digit = int.Parse(num[j].ToString());
                    if (digit != 0)
                    {
                        if (N % digit == 0)
                        {
                            final += digit;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (final.Length < 4)
                {
                    continue;
                }
                Console.Write(final + " ");
            }
        }
    }
}
