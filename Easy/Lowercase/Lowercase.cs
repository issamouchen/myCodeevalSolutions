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
             char[] output = new char[line.Length];
                for (int i = 0; i < line.Length; i++)
                {
                    char c = line[i];
 
                    if (c >= 'A' && c <= 'Z') { c = (char)(c | 32); }
                    output[i] = c;
                }

                Console.WriteLine(new string(output));
        }
    }
} 
