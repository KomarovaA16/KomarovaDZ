using System;

namespace КомароваЗадание4
{
    class Program
    {
        
        static double q
        {
            get
            {
                double q = Math.Sqrt(3);
                return q;
                
            }
        }
        static double w
        {
            get
            {
                double w = Math.Sqrt(2);
                return w;
                
            }
        }
        static double e
        {
            get
            {
                double e = Math.Sqrt(5);
                return e;
                
            }
        }
        static double r
        {
            get
            {
                double r = Math.Sqrt(11);
                return r;
            }
        }
        static double t
        {
            get
            {
                double t = Math.Sqrt(7);
                return t;
            }
        }

            static void Main(string[] args)
        {
            double x;
            Console.WriteLine(Math.Round(value: x = (q - w)/(q+w) + (e-q)/(e+q) + (r-t)/(r+t), digits: 3));
            Console.ReadKey();
        }

    }
}
        
