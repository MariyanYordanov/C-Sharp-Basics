using System;

namespace _003._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendedCounter = 0;

            while (ownedMoney < neededMoney && spendedCounter < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (action == "spend")
                {
                    spendedCounter++;
                    ownedMoney -= money;
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }

                }
                else if (action == "save")
                {
                    spendedCounter = 0;
                    ownedMoney += money;
                }
                if (ownedMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                    break;
                }
            }
            if (spendedCounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
        }
    }
}
