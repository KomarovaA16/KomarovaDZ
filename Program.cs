using System;

namespace КомароваЗадание8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член прогрессии");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите последний член прогрессии");
            var n = double.Parse(Console.ReadLine());
            var summ = 0;
            for (var i=a;i<=n;i++)
            {
                summ = (int)(summ + i); ;
            }
            Console.WriteLine($"Cумма членов прогрессии равна {summ}");
        }
    }
}
