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
                int target = int.Parse(split[0]);
                int n = int.Parse(split[1]);
                int sum = n;

                while (sum < target) { sum += n; }
                Console.WriteLine(sum);
        }
    }
} 
