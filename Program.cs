using System;

namespace КомароваЗадание7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Х : ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Значение функции f(x) = {Metod(x)}");
        }
        static double Metod (double x)
        {
            double f;
            if (x < -1)
                f = 1;
            else
            {
                if (x <= 1)
                    f = Math.Pow(x, 2);
                else
                    f = 2 - x;
            }

            return f;
        }
    }
}
