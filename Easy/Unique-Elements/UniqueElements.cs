
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
             string[] split = line.Split(',');
                StringBuilder sb = new StringBuilder();

                string lastAdded = String.Empty;
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i] != lastAdded)
                    {
                        sb.AppendFormat("{0},", split[i]);
                        lastAdded = split[i];
                    }
                }

                Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
} 
