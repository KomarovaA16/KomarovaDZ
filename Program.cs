using System;

namespace КомароваЗадание8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите границу дружественных чисел");
            var n = double.Parse(Console.ReadLine());
            var result = 1;
            var sdel = 0;
            for (int i=2;i<n;i++)
            {
                if (n % i == 0)
                    result = result + i;
                sdel = result;
            }
            for (int i =1;i<(n-1);i++)
            {
                for (var j = (i + 1); j < n; j++)
                    if ((sdel == j) && (sdel == i) && (j > i))
                    {
                        Console.WriteLine($"Два дружественных числа:{i},{j}");
                    }
                    else Console.WriteLine("Дружественных чисел до указанной границы нет");
            }
        }
    }
}
