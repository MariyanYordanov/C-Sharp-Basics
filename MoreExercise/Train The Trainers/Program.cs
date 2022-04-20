using System;

namespace _004._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double sum = 0;
            double sumGrade = 0;
            double counter = 0;
            double counterGrade = 0;
            while (presentation != "Finish")
            {
                for (int i = 0; i < jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    counter++;
                    counterGrade++;
                    sum += grade;
                    sumGrade += grade;
                }
                double averagePresentation = sumGrade / counterGrade;
                Console.WriteLine($"{presentation} - {averagePresentation:f2}.");
                counterGrade = 0;
                sumGrade = 0;
                presentation = Console.ReadLine();
            }
            double averageTotal = sum / counter;
            Console.WriteLine($"Student's final assessment is {averageTotal:f2}.");
        }
    }
}
