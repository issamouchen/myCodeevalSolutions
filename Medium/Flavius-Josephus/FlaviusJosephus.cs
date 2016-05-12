using System;
using System.Text;
using System.IO;
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
            
                    var split = Array.ConvertAll(line.Split(','), int.Parse);
                    int n = split[0];
                    int killDistance = split[1];
                    var deaths = new bool[n];
                    int deathCount = 0;
                    var sb = new StringBuilder();
                     
                    for (int i = 0; deathCount < n; i = (i + 1) % n)
                    { 
                        if (!deaths[i] && --killDistance == 0)
                        {
                            deaths[i] = true;
                            deathCount++;
                            killDistance = split[1];
                            sb.AppendFormat("{0} ", i);
                        }
                    }

                    Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
} 
