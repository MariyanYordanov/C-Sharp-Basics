using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int conterWin = 0;
            int conterLose = 0;
            double money = 0;
            
            for (int i = 1; i <= days; i++)
            {
                string games = Console.ReadLine();
                double moneyForDay = 0;
                int conterWinForDay = 0;
                int conterLoseForDay = 0;
                while (games != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        conterWinForDay++;
                        conterWin++;
                        moneyForDay += 20;
                    }
                    if (result == "lose")
                    {
                        conterLoseForDay++;
                        conterLose++;
                    }

                    games = Console.ReadLine();
                }
                if (conterWinForDay > conterLoseForDay)
                {
                    moneyForDay *= 1.1;
                }
                money += moneyForDay;
            }

            if (conterWin > conterLose)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {money * 1.2:f2}");
            }
            else if (conterLose > conterWin)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");
            }

        }
    }
}
