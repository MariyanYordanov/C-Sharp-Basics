using System;

namespace _0002._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doc = 7;

            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= period; i++)
            {
                int patient = int.Parse(Console.ReadLine());

                if ((i % 3 == 0) && (untreatedPatients > treatedPatients))
                {
                    doc += 1;
                }
                if (patient <= doc)
                {
                    treatedPatients += patient;
                }
                if (patient > doc)
                {
                    untreatedPatients += patient - doc;
                    treatedPatients += doc;
                }
                
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
