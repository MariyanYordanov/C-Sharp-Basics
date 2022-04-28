using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtTank = int.Parse(Console.ReadLine());
            int widthTank = int.Parse(Console.ReadLine());
            int heightTank = int.Parse(Console.ReadLine());
            double porcent = double.Parse(Console.ReadLine());

            double volumeWhithoutPorcent = (lenghtTank * widthTank * heightTank) * 0.001;
            double diferens = volumeWhithoutPorcent - (volumeWhithoutPorcent * (porcent * 0.01));

            Console.WriteLine(diferens);
        }
    }
}
