
using System;
using System.IO;

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
                    // The case flag, is bit 6 (n^5 = 32) in asci
                    // upper case: bit 6 = 0
                    // lower case: bit 6 = 1
                    char c = line[i];
                    if (c >= 'a' && c <= 'z') { c = (char)(c & (255 - 32)); }
                    else if (c >= 'A' && c <= 'Z') { c = (char)(c | 32); }

                    output[i] = c;
                }

                Console.WriteLine(new string(output));
        }
    }
} 
