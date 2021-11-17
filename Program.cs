using System;

namespace КомароваЗадание6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значения k,m,n : ");
            var k = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            if (k > 15)
            {
                if (m > 15)
                {
                    Console.WriteLine("m не удовлетворяет условию, F=0");
                }
                else
                {
                    if (n > 15)
                    {
                        Console.WriteLine("n не удовлетворяет условию, F=0");
                    }
                    else Console.WriteLine("F=1");
                }
            }
            else
            {
                if (m > 15)
                {
                    if (n > 15)
                    {
                        Console.WriteLine("n не удовлетворяет условию, F=0");
                    }
                    else Console.WriteLine("F=1");
                }
                else
                {
                    if (n > 15)
                    {
                        Console.WriteLine("F=1");
                    }
                    else Console.WriteLine("n не удовлетворяет условию, F=0");
                }

            }
        }
    }
}