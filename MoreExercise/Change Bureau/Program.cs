using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            double changeBitcoins = bitcoin * 1168;
            double changeYuan = yuan * 0.15 * 1.76;

            double euro = (changeYuan + changeBitcoins) / 1.95;
            double euroComision = euro * comision / 100;
            double total = euro - euroComision;
            Console.WriteLine($"{total:f2}");
        }
    }
}
