using System;

namespace KомароваЗадание2
{
    class Program
    {
        static void Main(string[] args)
        {
            var base1 = double.Parse(Console.ReadLine());
            var base2 = double.Parse(Console.ReadLine());
            var heightSide = double.Parse(Console.ReadLine());
            double sideC = Math.Sqrt(Math.Pow(heightSide,2)+(Math.Pow(base1-base2,2))/4);
            double trP = base1 + base2 + 2 * sideC;
            Console.WriteLine($"Периметр трапеции - {trP}");
            Console.ReadLine();
            double trPl = (base1 + base2) / 2 * heightSide;
            Console.WriteLine($"Площадь трапеции - {trPl}");
            Console.ReadLine();

        }
    }
}
