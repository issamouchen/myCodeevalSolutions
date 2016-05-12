using System;
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
             string[] split = line.Split(',');
                int num = int.Parse(split[0]);
 
                int p1 = int.Parse(split[1]) - 1;
                int p2 = int.Parse(split[2]) - 1;
                int r1 = (num >> p1) & 1;
                int r2 = (num >> p2) & 1;

                Console.WriteLine(r1 == r2 ? "true" : "false");
        }
    }
} 
