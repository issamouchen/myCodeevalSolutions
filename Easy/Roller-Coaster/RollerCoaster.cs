
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
                bool makeUpperCase = true;
                for (int i = 0; i < line.Length; i++)
                {
                    char c = line[i];
                    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    {
                        // The case flag, is bit 6 (n^5 = 32) in asci
                        // upper case: bit 6 = 0
                        // lower case: bit 6 = 1
                        if (makeUpperCase) { c = (char)(c & (255 - 32)); }
                        else { c = (char)(c | 32); }
                        makeUpperCase = !makeUpperCase;
                    }

                    output[i] = c;
                }

                Console.WriteLine(new string(output));
        }
    }
} 
