using System;

namespace КомароваЗадание8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дистанцию в первый день :");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент, на который каждый день увеличивается дистанция :");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите нужную конечную дистанцию :");
            double k = double.Parse(Console.ReadLine());
            var d = 1;
            while (n<=k)
            {
                n = n +(n*m*0.01);
                d++;
            }
            Console.WriteLine($"Эту дистанцию можно пробежать за {d} д.");
        }
    }
}
