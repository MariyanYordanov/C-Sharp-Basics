using System;

namespace _04._Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudent = int.Parse(Console.ReadLine());

            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double counter5 = 0;
            double sum = 0;
            for (int i = 0; i < numberStudent; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                sum += grade;

                if (grade >= 2.00 && grade <= 2.99)
                {
                    counter2++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    counter3++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    counter4++;
                }
                else if (grade >= 5.00)
                {
                    counter5++;
                }
            }
            double porcent2 = counter2 / numberStudent * 100;
            double porcent3 = counter3 / numberStudent * 100;
            double porcent4 = counter4 / numberStudent * 100;
            double porcent5 = counter5 / numberStudent * 100;
            double average = sum / numberStudent;

            Console.WriteLine($"Top students: {porcent5:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {porcent4:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {porcent3:f2}%");
            Console.WriteLine($"Fail: {porcent2:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
