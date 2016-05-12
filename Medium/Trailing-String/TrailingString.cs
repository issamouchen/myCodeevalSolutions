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
             var split = line.Split(',');
                        string text = split[0];
                        string candidate = split[1];

                        bool found = false;
                        if (candidate.Length <= text.Length)
                        {
                            string subString = text.Substring(text.Length - candidate.Length);
                            if (subString == candidate) { found = true; }
                        }

                        Console.WriteLine(found ? 1 : 0);
        }
    }
} 
