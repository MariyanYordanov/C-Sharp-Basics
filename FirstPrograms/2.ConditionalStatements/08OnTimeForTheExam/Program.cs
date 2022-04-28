using System;

namespace _08OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int exanTimeHour = int.Parse(Console.ReadLine());
            int examTimeMin = int.Parse(Console.ReadLine());
            int arriveTimeHour = int.Parse(Console.ReadLine());
            int arriveTimeMin = int.Parse(Console.ReadLine());

            int examTime = (exanTimeHour * 60) + examTimeMin;
            int arriveTime = (arriveTimeHour * 60) + arriveTimeMin;
            int early = (examTime - 30);
            int difMinutes = Math.Abs(examTime - arriveTime);

            if (arriveTime < early)
            {
                if (difMinutes <= 9)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difMinutes} minutes before the start");
                }
                else if (difMinutes <= 59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difMinutes:D2} minutes before the start");
                }
                else if (difMinutes > 59)
                {
                    int difHour = difMinutes / 60;
                    int pre = difMinutes - (difHour * 60);
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difHour}:{pre:D2} hours before the start");
                }
            }
            else if (arriveTime <= examTime)
            {
                if (arriveTime == examTime)
                {
                    Console.WriteLine("On time");
                }
                else if (difMinutes <= 9)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difMinutes} minutes before the start");
                }
                else if (difMinutes <= 59)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difMinutes:D2} minutes before the start");
                }
                else if (difMinutes > 59)
                {
                    int difHour = difMinutes / 60;
                    int pre = difMinutes - (difHour * 60);
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difHour}:{pre:D2} hours before the start");
                }
            }
            else if (arriveTime > examTime)
            {
                if (difMinutes <= 9)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{difMinutes} minutes after the start");
                }
                else if (difMinutes <= 59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{difMinutes:D2} minutes after the start");
                }
                else if (difMinutes > 59)
                {
                    int difHour = difMinutes / 60;
                    int pre = difMinutes - (difHour * 60);
                    Console.WriteLine("Late");
                    Console.WriteLine($"{difHour}:{pre:D2} hours after the start");
                }
            }
        }
    }
}
