
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
              var distances = new List<int>();
                int i = 0;
                while ((i = line.IndexOf(',', i + 1)) != -1)
                {
                    // Rkbs,5453;
                    // 0123456789
                    // 9 - 5 = 4
                    int j = line.IndexOf(';', ++i);
                    int length = j - i;
                    distances.Add(int.Parse(line.Substring(i, length)));
                }

                distances.Sort();
                StringBuilder sb = new StringBuilder();
                int prev = 0;
                for (i = 0; i < distances.Count; i++) 
                {
                    sb.AppendFormat("{0},", distances[i] - prev);
                    prev = distances[i];
                }

                Console.WriteLine(sb.ToString(0, sb.Length -1));
        }
    }
} 
