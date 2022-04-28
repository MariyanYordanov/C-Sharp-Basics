using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char star = '*';
            char slash = '/';
            char vertinalLine = '|';
            char line = '_';
            char bracketLeft = '<';
            char bracketRight = '>';
            char bracketUp = '^';
            char space = ' ';

            
            for (int i = 0; i <= 7; i++)
            {
                if (i == 0)
                {
                    Console.Write(space);
                    Console.Write(space);
                    Console.Write(line);
                    Console.Write(line);
                    Console.Write(line);
                    Console.Write(space);
                    Console.Write(space);
                    Console.WriteLine();
                }
                if (i == 1)
                {
                    Console.Write(space);
                    Console.Write(vertinalLine);
                    Console.Write(line);
                    Console.Write(space);
                    Console.Write(line);
                    Console.Write(vertinalLine);
                    Console.Write(space);
                    Console.WriteLine();
                }
                if (i == 2)
                {
                    Console.Write(bracketLeft);
                    Console.Write(space);
                    Console.Write(star);
                    Console.Write(slash);
                    Console.Write(star);
                    Console.Write(space);
                    Console.Write(bracketRight);
                    Console.WriteLine();
                }
                if (i == 3)
                {
                    Console.Write(space);
                    Console.Write(vertinalLine);
                    Console.Write(line);
                    Console.Write(bracketUp);
                    Console.Write(line);
                    Console.Write(vertinalLine);
                    Console.Write(space);
                }
            }
            Console.WriteLine("Thanks for coding!");
        }
    }
}
