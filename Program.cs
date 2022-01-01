using System;

namespace КомароваЗадание6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату Х : ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y : ");
            double y = double.Parse(Console.ReadLine());
            if (Metod(y) == 1)
            Console.WriteLine("Точка принадлежит выбранному участку");
            else
                Console.WriteLine("Точка не принадлежит выбранному участку");
        }
        static double Metod (double y)
        {
            int F;
            if (y>1)
            {
                F=1;
            }
            else
            {
                if (y < -3)
                {
                    F=1;
                }
                F=0;
            }
            return F;
        }
    }
}
