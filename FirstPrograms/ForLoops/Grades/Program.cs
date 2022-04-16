using System;

namespace _0004._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            double sumGrads = 0;
            for (int i = 1; i <= n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                
                sumGrads += grade;
                if (grade >= 2.00 && grade <= 2.99)
                {
                    count1++;
                }
                if (grade >= 3.00 && grade <= 3.99)
                {
                    count2++;
                }
                if (grade >= 4.00 && grade <= 4.99)
                {
                    count3++;
                }
                if (grade >= 5.00 && grade <= 6.00)
                {
                    count4++;
                } 
            }
            
            double top = count4 / n * 100; ;
            double veryGood = count3 / n * 100; ;
            double good = count2 / n * 100;
            double fail = count1 / n * 100;
            double average = sumGrads / n;
            Console.WriteLine($"Top students: {(top):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(veryGood):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(good):f2}%");
            Console.WriteLine($"Fail: {(fail):f2}%");
            Console.WriteLine($"Average: {(average):f2}");
        }
    }
}
