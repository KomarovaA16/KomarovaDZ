using System;

namespace КомароваЗадание3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Х : ");
            var x = double.Parse(Console.ReadLine());
            Console.Write($"Если Х = {x} ,то Y= ");
            double q = Math.Abs(x);
            double w = Math.Tan(x);
            double e = Math.Pow(w, 2);
            double r = Math.Sin(e + 4);
            Console.WriteLine(Math.Round((q + 2 * r) / (5.5 * x),3));

            }
        }
    }

