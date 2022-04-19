using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());
            string suitcaseVolume = Console.ReadLine();
            bool check = false;
            int counter = 0;
            
            while (suitcaseVolume != "End")
            {
                double volumeSuitcase = Convert.ToDouble(suitcaseVolume);
                counter++;

                if (counter % 3 == 0)
                {
                    volumeSuitcase *= 1.1;
                }
                if (trunkCapacity < volumeSuitcase)
                {
                    counter--;
                    check = true;
                    break;
                }
                trunkCapacity -= volumeSuitcase;
                suitcaseVolume = Console.ReadLine();
            }
            if (check)
            {
                Console.WriteLine($"No more space!");
            }
            if (suitcaseVolume == "End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
