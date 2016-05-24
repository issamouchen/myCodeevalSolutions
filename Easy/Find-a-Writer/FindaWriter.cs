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
             string[] split = line.Split('|');
                int[] indexes = Array.ConvertAll(split[1].Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s) - 1);
                char[] output = new char[indexes.Length];

                for (int i = 0; i < indexes.Length; i++)
                {
                    output[i] = split[0][indexes[i]];
                }
               
                Console.WriteLine(output);
        }
    }
} 
