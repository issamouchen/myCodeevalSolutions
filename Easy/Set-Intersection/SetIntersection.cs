
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
            string[] split = line.Split(';');
                int[] setA = Array.ConvertAll(split[0].Split(','), int.Parse);
                int[] setB = Array.ConvertAll(split[1].Split(','), int.Parse);
                StringBuilder sb = new StringBuilder();
                    
                int i = 0, j = 0;
                while (i < setA.Length && j < setB.Length)
                { 
                    int delta = setA[i] - setB[j];
                    if (delta > 0)
                    { 
                        j++;
                    }
                    else if (delta < 0)
                    { 
                        i++;
                    }
                    else
                    { 
                        sb.AppendFormat("{0},", setA[i]);
                        i++;
                        j++;
                    }
                }

                Console.WriteLine(sb.Length > 0 ? sb.ToString(0, sb.Length - 1) : "");
        }
    }
} 
