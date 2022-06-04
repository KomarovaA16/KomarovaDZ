using System;
using System.IO;
using System.Text;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = new int[10][];
            int index = 0;
            int lastDigit = 0;
            nums[lastDigit] = new int[0];
            Console.WriteLine("Входной файл:");
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    int[] arrLine = Array.ConvertAll(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), Int32.Parse);
                    for (int i = 0; i < arrLine.Length; i++)
                    {
                        lastDigit = arrLine[i] % 10;

                        if (nums[lastDigit]?.Length is null)
                        {
                            index = 0;
                            nums[lastDigit] = new int[index];
                        }
                        else
                        {
                            index = nums[lastDigit].Length;
                        }
                        Array.Resize(ref nums[lastDigit], nums[lastDigit].Length + 1);
                        nums[lastDigit][index] = arrLine[i];
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                int line = 0;
                StringBuilder stringBuilder = new StringBuilder();
                foreach (int[] row in nums)
                {
                    stringBuilder.Append($"{line++}: ");
                    if (row?.Length != null)
                    {
                        foreach (var r in row)
                        {
                            stringBuilder.Append(r + " ");
                        }
                    }
                    stringBuilder.AppendLine();
                }
                writer.Write(stringBuilder.ToString());
            }
            Console.WriteLine("Выходной файл:");
            using (StreamReader reader = new StreamReader("output.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
