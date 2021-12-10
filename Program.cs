using System;

namespace КомароваЗадание8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n :");
            var n = double.Parse(Console.ReadLine());
            Console.WriteLine("Натуральные числа, квадрат которых меньше n :");
            for (var i=1;Math.Pow(i,2)<n;i++)
                {
                Console.Write($"{i}, ");
                }
        }
    }
}
