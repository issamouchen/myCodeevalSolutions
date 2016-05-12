
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

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
             string[] split = line.Split(' ');
                StringBuilder sb = new StringBuilder();
                double[] numbers = new double[split.Length];
                for (int i = 0; i < split.Length; i++) { numbers[i] = double.Parse(split[i]); }
                Array.Sort(numbers);
                 foreach (double number in numbers) { sb.AppendFormat("{0:F3} ", number); }
                Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
} 
