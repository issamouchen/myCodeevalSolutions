using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
          string[] lines = File.ReadAllLines(args[0]);
            int n = int.Parse(lines[0]);
            Comparison<string> lengthDescending = (x, y) => x.Length > y.Length ? -1 : x.Length < y.Length ? 1 : 0;
            Array.Sort(lines, lengthDescending);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(lines[i]);
            }
    }
} 
