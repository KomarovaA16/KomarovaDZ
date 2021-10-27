using System;

namespace КомароваЗадание4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine(Math.Round(value: x = Metod, digits: 3));
            Console.ReadKey();
        }
        static double Metod
        {
            get
            {
                double x;
                double q = Math.Sqrt(3);
                double w = Math.Sqrt(2);
                double e = Math.Sqrt(5);
                double r = Math.Sqrt(11);
                double t = Math.Sqrt(7);
                return x = ((q - w) / (q + w) + (e - q) / (e + q) + (r - t) / (r + t));
            }
        }
    }
}
