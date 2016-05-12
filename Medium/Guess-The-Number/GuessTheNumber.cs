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
            
                    var split = line.Split(' ');
                    int lowerBound = 0;
                    int upperBound = int.Parse(split[0]);
                    int mid = 0;
                     
                    for (int i = 1; i < split.Length; i++)
                    {
                        mid = lowerBound + (upperBound - lowerBound + 1) / 2;
                        if (split[i] == "Lower") { upperBound = mid - 1; }
                        else if (split[i] == "Higher") { lowerBound = mid + 1; }
                    }

                    Console.WriteLine(mid);

        }
    }
} 
