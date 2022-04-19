using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashine = double.Parse(Console.ReadLine());
            double toys = double.Parse(Console.ReadLine());

            double savedMoney = 0;
            double toysMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += ((i / 2 )* 10) - 1;
                }
                else
                {
                    toysMoney = toys * (i / 2) + toys;   
                }
            }
            double totalMoney = savedMoney + toysMoney;
            if (washingMashine <= totalMoney)
            {
                Console.WriteLine($"Yes! {(totalMoney - washingMashine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMashine - totalMoney):f2}");
            }
        }
    }
}
