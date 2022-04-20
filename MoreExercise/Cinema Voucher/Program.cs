using System;

namespace _04._Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());
            string purchase = Console.ReadLine();
            int counterTickets = 0;
            int counterOthers = 0;
            while (purchase != "End")
            {

                char num1 = purchase[0];
                char num2 = purchase[1];
                int purchasePrice = 0;
                if (purchase.Length > 8)
                {
                    purchasePrice = num1 + num2;
                    if (purchasePrice <= voucher)
                    {
                        counterTickets++;
                        voucher -= purchasePrice;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (purchase.Length <= 8)
                {
                    purchasePrice = num1;
                    if (purchasePrice <= voucher)
                    {
                        counterOthers++;
                        voucher -= purchasePrice;
                    }
                    else
                    {
                        break;
                    }
                }
                
                purchase = Console.ReadLine();
            }
            Console.WriteLine($"{counterTickets}");
            Console.WriteLine($"{counterOthers}");
        }
    }
}
