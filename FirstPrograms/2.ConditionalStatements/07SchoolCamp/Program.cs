using System;

namespace _07SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int numberStudent = int.Parse(Console.ReadLine());
            int numberOvernights = int.Parse(Console.ReadLine());

            double overnightPrice = 0;
            double overnightAfterDiscount = 0;
            string sport = "";

            if ((typeOfGroup == "boys" || typeOfGroup == "girls") && (season == "Winter"))
            {
                overnightPrice = 9.6 * numberStudent * numberOvernights;
            }
            else if ((typeOfGroup == "boys" || typeOfGroup == "girls") && (season == "Spring"))
            {
                overnightPrice = 7.2 * numberStudent * numberOvernights;
            }
            else if ((typeOfGroup == "boys" || typeOfGroup == "girls") && (season == "Summer"))
            {
                overnightPrice = 15 * numberStudent * numberOvernights;
            }
            else if (typeOfGroup == "mixed" && season == "Winter")
            {
                overnightPrice = 10 * numberStudent * numberOvernights;
            }
            else if (typeOfGroup == "mixed" && season == "Spring")
            {
                overnightPrice = 9.5 * numberStudent * numberOvernights;
            }
            else if (typeOfGroup == "mixed" && season == "Summer")
            {
                overnightPrice = 20 * numberStudent * numberOvernights;
            }


            if (numberStudent < 10 )
            {
                overnightAfterDiscount = overnightPrice;
            }
            else if (numberStudent >= 10 && numberStudent < 20)
            {
                overnightAfterDiscount = overnightPrice * 0.95;
            }
            else if (numberStudent >= 20 && numberStudent < 50)
            {
                overnightAfterDiscount = overnightPrice * 0.85;
            }
            else if (numberStudent > 50)
            {
                overnightAfterDiscount = overnightPrice * 0.5;
            }

            if (typeOfGroup == "girls" && season == "Winter")
            {
                sport = "Gymnastics";
            }
            else if (typeOfGroup == "girls" && season == "Spring")
            {
                sport = "Athletics";
            }
            else if (typeOfGroup == "girls" && season == "Summer")
            {
                sport = "Volleyball";
            }
            else if (typeOfGroup == "boys" && season == "Winter")
            {
                sport = "Judo";
            }
            else if (typeOfGroup == "boys" && season == "Spring")
            {
                sport = "Tennis";
            }
            else if (typeOfGroup == "boys" && season == "Summer")
            {
                sport = "Football";
            }
            else if (typeOfGroup == "mixed" && season == "Winter")
            {
                sport = "Ski";
            }
            else if (typeOfGroup == "mixed" && season == "Spring")
            {
                sport = "Cycling";
            }
            else if (typeOfGroup == "mixed" && season == "Summer")
            {
                sport = "Swimming";
            }
            Console.WriteLine($"{sport} {overnightAfterDiscount:f2} lv.");
        }
    }
}
