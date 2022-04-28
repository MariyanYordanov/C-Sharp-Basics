using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            string simbol = Console.ReadLine();

            double result = 0;
            if (simbol == "*")
            {
                result = numOne * numTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numOne} {simbol} {numTwo} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{numOne} {simbol} {numTwo} = {result} - odd");
                }
            }
            else if (simbol == "+")
            {
                result = numOne + numTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numOne} {simbol} {numTwo} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{numOne} {simbol} {numTwo} = {result} - odd");
                }
            }
            else if (simbol == "-")
            {
                result = numOne - numTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numOne} {simbol} {numTwo} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{numOne} {simbol} {numTwo} = {result} - odd");
                }
            }

            

            if (simbol == "/" && numTwo != 0)
            {
                result = numOne / numTwo;
                Console.WriteLine($"{numOne} {simbol} {numTwo} = {result:f2} ");
            }
            else if (simbol == "/" && numTwo == 0)
            {
                Console.WriteLine($"Cannot divide {numOne} by zero");
            }
            else if (simbol == "%" && numTwo != 0)
            {
                result = numOne % numTwo;
                Console.WriteLine($"{numOne} {simbol} {numTwo} = {result}");
            }
            else if (simbol == "%" && numTwo == 0)
            {
                Console.WriteLine($"Cannot divide {numOne} by zero");
            }

        }
    }
}
