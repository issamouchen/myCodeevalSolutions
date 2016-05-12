 using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         var fiboSequence = new List<ulong>() { 0, 1 };
            string[] lines = File.ReadAllLines(args[0]);
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
             int fiboIndex = int.Parse(line);
                for (int i = fiboSequence.Count - 1; i < fiboIndex; i++)
                {
                    fiboSequence.Add(fiboSequence[i] + fiboSequence[i - 1]);
                }

                Console.WriteLine(fiboSequence[fiboIndex]);
        }
    }
}
