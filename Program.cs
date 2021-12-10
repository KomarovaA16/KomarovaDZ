using System;

namespace КомароваЗадание8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите границу перевода");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение шага");
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("Таблица перевода из дюймов в сантиметры :");
            for (var i = 1; i < a;)
            {
                var x = 2.54*i;
                Console.WriteLine($"{i} д. = {x} см");
                i= (int)(i + h);
            }
        }
    }
}

