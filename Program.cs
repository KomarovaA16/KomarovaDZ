using System;

namespace КомароваЗадание8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число : ");
            var x = double.Parse(Console.ReadLine());
            var y = x % 10;
            var s = 0;
            while (x>0)
            {
                if ((x % 10) == y)
                {
                    s++;
                    x = (int)(x / 10);
                }
                else
                {
                    x = (int)(x / 10);
                }
            }
            Console.WriteLine($"Цифра {y} встречается в записи числа {s} р.");
        }
    }
}
