using System;

namespace _006._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tab = int.Parse(Console.ReadLine());
            double salery = double.Parse(Console.ReadLine());

            for (int i = 0; i < tab && salery > 0; i++ )
            {
                string website = Console.ReadLine();
                
                if (website == "Facebook")
                {
                    salery -= 150;
                }
                if (website == "Instagram")
                {
                    salery -= 100;
                }
                if (website == "Reddit")
                {
                    salery -= 50;
                }
            }
            if (salery <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salery);
            }

            //SECOND WAY TO SOLVE THE TASK

            //int tab = int.Parse(Console.ReadLine());
            //double salery = double.Parse(Console.ReadLine());

            //for (int i = 0; i < tab; i++)
            //{
            //    string website = Console.ReadLine();

            //    if (website == "Facebook" && salery > 0)
            //    {
            //        salery -= 150;
            //    }
            //    if (website == "Instagram" && salery > 0)
            //    {
            //        salery -= 100;
            //    }
            //    if (website == "Reddit" && salery > 0)
            //    {
            //        salery -= 50;
            //    }
            //    if (salery <= 0)
            //    {
            //        break;
            //    } 
            //}
            //if (salery <= 0)
            //{
            //    Console.WriteLine("You have lost your salary.");
            //}
            //else
            //{
            //    Console.WriteLine(salery);
            //}
        }
    }
}
