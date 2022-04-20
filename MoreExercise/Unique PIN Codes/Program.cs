using System;

namespace _0001._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            string letterP = string.Empty;
            string letterI = string.Empty;
            string letterN = string.Empty;

            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 == 0)
                {
                    letterP += i;
                    for (int j = 2; j <= num2; j++)
                    {
                        string num = j.ToString();
                        int number = int.Parse(num);

                        bool check = true;
                        int divider = 2;
                        int dividerMax = (int)Math.Sqrt(number);

                        while (check && (divider <= dividerMax))
                        {
                            if (number % divider == 0)
                            {
                                check = false;
                            }
                            divider++;
                        }
                        if (check)
                        {
                            letterI += number;
                            for (int k = 1; k <= num3; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    letterN += k;
                                    Console.WriteLine(letterP + " " + letterI + " " + letterN);
                                    letterN = string.Empty;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }
                        letterI = string.Empty;
                    }
                }
                else
                {
                    continue;
                }
                letterP = string.Empty;
            }
        }
    }
}
