
using System;
using System.IO;
using System.Collections.Generic;
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
             string[] split = line.Split(':');
                string[] numbers = split[0].Split(' ');
                string[] swapList = split[1].Split(',');
 
                for (int i = 0; i < swapList.Length; i++)
                {
                    var idx = Array.ConvertAll(swapList[i].Trim().Split('-'), int.Parse);
                    Swap(numbers, idx[0], idx[1]);
                }

                var sb = new StringBuilder(split[0].Length);
                foreach (var number in numbers)
                {
                    sb.AppendFormat("{0} ", number);
                }

                Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
    static void Swap<T>(IList<T> data, int i, int j)
        {
            T temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
} 
