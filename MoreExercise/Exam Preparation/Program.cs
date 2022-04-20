using System;

namespace _002._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine());
            string problem = Console.ReadLine();
            
            int counterPoorGrade = 0;
            int counterGrade = 0;
            double sum = 0;
            string lastProblem = string.Empty;
            bool check = false;

            while (problem != "Enough")
            {
                int problemGrade = int.Parse(Console.ReadLine());

                sum += problemGrade;
                counterGrade++;
                
                if (problemGrade <= 4)
                {
                    counterPoorGrade++;
                }
                if (counterPoorGrade == grade)
                {
                    check = false;
                    break;
                }
                check = true;
                lastProblem = problem;
                problem = Console.ReadLine();
            }
            double average = sum / counterGrade; 
            if (check)
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {counterGrade}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {counterPoorGrade} poor grades."); 
            }
        }
    }
}
