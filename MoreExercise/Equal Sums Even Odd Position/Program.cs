using System;

namespace _002._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            //for (int i = first; i <= second; i++)
            //{
            //    int current = i;
            //    int sumOdd = 0;
            //    int sumEven = 0;

            //    for (int j = 6; j > 0; j--)
            //    {
            //        int divModu = current % 10;

            //        if (j % 2 == 0)
            //        {
            //            sumEven += divModu;
            //        }
            //        else
            //        {
            //            sumOdd += divModu;
            //        }

            //        current /= 10;

            //    }
            //    if (sumEven == sumOdd)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            
            
            for (int i = first; i <= second; i++)
            {
                string current = i.ToString(); // преобразуване от инт към стринг и запазване в нова променлива
                int odd = 0;
                int even = 0;
                for (int J = 0; J < current.Length; J++)
                {
                    int digit = int.Parse(current[J].ToString()); // четене на всеки отделен елемент от чар current[j] към стринг To.String() "j" и после парсване към инт int.Parse
                    if (J % 2 == 0)
                    {
                        odd += digit;
                    }
                    else
                    {
                        even += digit;
                    }
                }
                if (odd == even)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
