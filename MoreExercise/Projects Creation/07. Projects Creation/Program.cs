using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());

            int hoursPerProject = 3;
            int totalProjectHours = project * hoursPerProject;
            
            
             
            Console.WriteLine($"The architect {architectName} will need {totalProjectHours} hours to complete {project} project/s.");
        }
    }
}
