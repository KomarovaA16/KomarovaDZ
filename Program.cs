using System;

namespace КомароваЗадание6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения k,m,n : ");
            var k = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"F={Metod(k,m,n)}");
        }
        static int Metod(int k, int m, int n)
        {
            int F;
            if (k > 15)
            {
                if (m > 15)
                {
                    F = 0;
                }
                else
                {
                    if (n > 15)
                    {
                        F = 0;
                    }
                    else F=1;
                }
            }
            else
            {
                if (m > 15)
                {
                    if (n > 15)
                    {
                        F=0;
                    }
                    else F=1;
                }
                else
                {
                    if (n > 15)
                    {
                       F=1;
                    }
                    else F=0;
                }

            }
            return F;
        }
    }
}