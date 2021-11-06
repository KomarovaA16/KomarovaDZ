using System;

namespace КомароваЗадание4
{
    class Program
    {

        static double Metod(double q,double w)
        {
            return (Math.Sqrt(q)-Math.Sqrt(w))/(Math.Sqrt(q) + Math.Sqrt(w)); 


        }

            static void Main(string[] args)
        {
            double x = Metod(3,2)+Metod(5,3)+Metod(11,7);
            Console.WriteLine($"x = {x:F3}");
        }

    }
}
        
