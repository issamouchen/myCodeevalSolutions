using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines(args[0]);
            int sum = 0;
            foreach (var line in lines) { sum += int.Parse(line); }
            Console.WriteLine(sum);
    }
} 
