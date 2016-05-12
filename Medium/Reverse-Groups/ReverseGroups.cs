 using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
             string[] split = line.Split(';');
                int[] numbers = Array.ConvertAll(split[0].Split(','), int.Parse);
                int k = int.Parse(split[1]);
 
                for (int i = 0; i + k - 1 < numbers.Length; i += k)
                {
                    Reverse(numbers, i, k);
                }
 
                var sb = new StringBuilder(numbers.Length * 2);
                foreach (var number in numbers) { sb.AppendFormat("{0},", number); }
                Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
     static void Reverse<T>(IList<T> data, int startIndex, int length)
        {
            int endIndex = startIndex + length - 1;
            while (startIndex < endIndex)
            {
                Swap(data, startIndex++, endIndex--);
            }
        }
        static void Swap<T>(IList<T> data, int i, int j)
        {
            T temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }

} 
