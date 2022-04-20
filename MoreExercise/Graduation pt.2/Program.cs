using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countGrade = 0;
            int countBadGrade = 0;
            double sum = 0;
            bool check = false;
            while (countGrade != 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    check = true;
                    sum += grade;
                    countGrade++;
                }
                else
                {
                    countBadGrade++;

                    if (countBadGrade == 2)
                    {
                        check = false;
                        break;
                    }
                }
            }
            if (check)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(sum / 12):f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {countGrade + 1} grade");
            }
        }
    }
}
