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
             int sum = 0;
                for (int i = 0; i < line.Length; i++)
                { 
                    int digit = line[i] - '0';
                    sum += digit;
                }

                Console.WriteLine(sum);
        }
    }
} 
