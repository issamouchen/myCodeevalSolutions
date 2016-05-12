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
            
                    var split = Array.ConvertAll(line.Split(' '), int.Parse);
                    int wire = split[0];
                    int distance = split[1]; 
                    int initialBatCount = split[2];
                    if (initialBatCount > 0) { Array.Sort(split, 3, initialBatCount); }

                    
                    int pos = 6;
                    int count = 0;
                    int i = 3;

                    
                    while (pos <= wire - 6)
                    {
                        int bat = i < split.Length ? split[i] : pos + distance;
                        if (pos <= bat - distance)
                        {
                             
                            count++;
                            pos += distance;
                        }
                        else
                        {
                             
                            pos = bat + distance;
                            i++;
                        }
                    }

                    Console.WriteLine(count);
        }
    }
} 
