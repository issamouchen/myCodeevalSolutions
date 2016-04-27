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
             line = line.Trim();
                    string[] rows = line.Split(",".ToCharArray());

                    int minimumDots = int.MaxValue;

                    foreach (string row in rows)
                    {
                        if (row.Contains("."))
                        {
                            int dots = row.IndexOf("Y", StringComparison.Ordinal) - row.LastIndexOf("X", StringComparison.Ordinal) - 1;

                            if (dots < minimumDots)
                            {
                                minimumDots = dots;
                            }
                        }
                        else
                        {
                            minimumDots = 0;
                        }
                    }

                    Console.WriteLine(minimumDots);
        }
    }
} 
