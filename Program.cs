using System;

namespace КомароваЗадание3
{
    class Program
    {

        public static double Metod(string x)
        {
            double z = double.Parse(x);
            return Math.Round(((Math.Abs(z) + 2 * Math.Sin((Math.Pow(Math.Tan(z), 2) + 4))) / (5.5 * z)),3);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите Х : ");
            string x = Console.ReadLine();
            Console.WriteLine(Metod(x));
        }

    }
    }

