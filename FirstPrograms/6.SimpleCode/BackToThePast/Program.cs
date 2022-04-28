

using System;
 
namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            double expences = 0;
            double totalExpences = 0;
            int age = 18;
            double moneyLeft = 0;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {

                    expences = 12000;
                    totalExpences = inheritance - expences;

                    moneyLeft += totalExpences;

                }
                else
                {
                    expences = 12000 + 50 * (age + 1);

                    moneyLeft = totalExpences - expences;

                }
            }
            double diff = Math.Abs(moneyLeft - inheritance);

            if (moneyLeft <= inheritance)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {diff:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {diff:f2} dollars to survive.");
            }
        }
    }
}



