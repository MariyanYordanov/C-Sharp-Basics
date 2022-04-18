using System;

namespace PiresInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int firstPipeDebit = int.Parse(Console.ReadLine());
            int secondPipeDebit = int.Parse(Console.ReadLine());
            double missing = double.Parse(Console.ReadLine());

            double firstPipeDebitPerMissing = firstPipeDebit * missing;
            double secondPipeDebitPerMissing = secondPipeDebit * missing;
            double sumVolume = firstPipeDebitPerMissing + secondPipeDebitPerMissing;

            if (sumVolume > poolVolume)
            {
                Console.WriteLine($"For {missing} hours the pool overflows with {sumVolume-poolVolume:f2} liters.");
            }
            else if (sumVolume <= poolVolume)
            {
                double sumVolumePorcenf = (sumVolume / poolVolume) * 100.0;
                double firstPipePorcent = (firstPipeDebitPerMissing / sumVolume) * 100.0;
                double secondPipePorcent = (secondPipeDebitPerMissing / sumVolume) * 100.0;
                Console.WriteLine($"The pool is {sumVolumePorcenf:f2}% full. Pipe 1: {firstPipePorcent:f2}%. Pipe 2: {secondPipePorcent:f2}%.");
            }
        }
    }
}
