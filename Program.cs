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
            string str = "";
            str = "Перемена";
            Console.WriteLine(str);

            string result1 = str.Substring(6,1) + str.Substring(1,2)  + str.Substring(0,1).ToLower() + str.Substring(7);
            Console.WriteLine(result1);

            string result2 = str.Substring(4, 2) + str.Substring(2, 1) + str.Substring(7);
            Console.WriteLine(result2);
            Console.ReadKey();
        }
    }
}
