
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Linq;


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
            string[] split = line.Split('|');
                int[] left = split[0].Trim().Split(' ').Select(int.Parse).ToArray();
                int[] right = split[1].Trim().Split(' ').Select(int.Parse).ToArray();
                Debug.Assert(left.Length == right.Length, "The 2 passed arrays have different element counts");

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < left.Length; i++) { sb.AppendFormat("{0} ", left[i] * right[i]); }

                Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
} 
