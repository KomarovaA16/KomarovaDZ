using System;

namespace КомароваЗадание6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату Х : ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y : ");
            var y = double.Parse(Console.ReadLine());
            if (y>1)
            {
                Console.WriteLine("Точка принадлежит выбранной области, F=1");
            }
            else
            {
                if (y < -3)
                {
                    Console.WriteLine("Точка принадлежит выбранной области, F=1");
                }
                else Console.WriteLine("Точка не принадлежит выбранной области, F=0");
            }
        }
    }
}
