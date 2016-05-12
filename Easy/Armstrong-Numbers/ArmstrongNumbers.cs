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
            int target = int.Parse(line);
                int n = line.Length;
                int num = target;
                int sum = 0;
 
                while (num != 0)
                {
                    int digit = num % 10;
                    sum += (int)Math.Pow(digit, n);
                    num = num / 10;
                }

                Console.WriteLine(sum == target ? "True" : "False");
        }
    }
} 
