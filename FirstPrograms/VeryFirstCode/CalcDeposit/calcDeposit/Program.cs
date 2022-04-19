using System;

namespace calcDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());
            double depositYearPorcent = double.Parse(Console.ReadLine());

            double dividend = deposit * depositYearPorcent / 100;
            double dividendPerMonth = dividend / 12;


            double sum = deposit + (dividendPerMonth * depositPeriod);
            Console.WriteLine(sum);
        }
    }
}
