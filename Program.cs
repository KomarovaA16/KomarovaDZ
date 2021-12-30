using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КомароваЗадание5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };
            var combinations = (
            from s1 in strings
            from s2 in strings.Where(s => s != s1)
            from s3 in strings.Where(s => s != s2 && s != s1)
            from s4 in strings.Where(s => s != s3 && s != s2 && s!= s1)
            from s5 in strings.Where(s => s != s4 && s != s3 && s != s2 && s != s1)
            from s6 in strings.Where(s => s != s5 && s != s4 && s != s3 && s != s2 && s != s1)
            from s7 in strings.Where(s => s != s6 && s != s5 && s != s4 && s != s3 && s != s2 && s != s1)
            from s8 in strings.Where(s => s != s7 && s != s6 && s != s5 && s != s4 && s != s3 && s != s2 && s != s1)
            from s9 in strings.Where(s => s != s8 && s != s7 && s != s6 && s != s5 && s != s4 && s != s3 && s != s2 && s != s1)
            from s10 in strings.Where(s => s != s9 && s != s8 && s != s7 && s != s6 && s != s5 && s != s4 && s != s3 && s != s2 && s != s1)
            from s11 in strings.Where(s => s != s10 && s != s9 && s != s8 && s != s7 && s != s6 && s != s5 && s != s4 && s != s3 && s != s2 && s != s1)
            from s12 in strings.Where(s => s != s11 && s != s10 && s != s9 && s != s8 && s != s7 && s != s6 && s != s5 && s != s4 && s != s3 && s != s2 && s != s1)
            select new { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12 }).Distinct();
            Console.WriteLine(" Введите порядковый номер нужной комбинации");
            string ns = Console.ReadLine();
            char[] str = ns.ToCharArray();
           
            foreach (var c in combinations)
            {
                Console.WriteLine($"{c.s1}{c.s2}{c.s3}{c.s4}{c.s5}{c.s6}{c.s7}{c.s8}{c.s9}{c.s10}{c.s11}{c.s12}");
            }
        }
        static double Factorial (int n)
        {
            var factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
