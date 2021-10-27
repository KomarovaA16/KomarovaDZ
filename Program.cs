using System;

namespace КомароваЗадание5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.Replace("a", "4");
            text = text.Replace("e", "3");
            text = text.Replace("i", "!");
            text = text.Replace("q", "9");
            text = text.Replace("b", "8");
            text = text.Replace("f", "|=");
            text = text.Replace("j", ")");
            text = text.Replace("r", "|2");
            text = text.Replace("z", "2");
            text = text.Replace("c", "(");
            text = text.Replace("g", "6");
            text = text.Replace("k", "|<");
            text = text.Replace("o", "0");
            text = text.Replace("s", "5");
            text = text.Replace("d", "|)");
            text = text.Replace("h", "|-|");
            text = text.Replace("l", "1");
            text = text.Replace("p", "|>");
            text = text.Replace("t", "7");
            text = text.Replace("x", "><");
            Console.WriteLine(text);

        }
    }
}
