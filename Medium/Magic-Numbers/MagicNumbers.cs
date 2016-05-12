using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            var split = line.Split(' ');
                int lowerBound = Convert.ToInt32(split[0]);
                int upperBound = Convert.ToInt32(split[1]);
                var magicNumbers = new List<int>();

                for (int x = lowerBound; x <= upperBound; x++)
                {
                    if (IsMagicNumber(x)) { magicNumbers.Add(x); }
                }

                Console.WriteLine(magicNumbers.Count > 0 ? String.Join(" ", magicNumbers) : "-1");
        }
    }
     static bool IsMagicNumber(int number)
        { 
            char[] a = number.ToString().ToCharArray();
            bool[] visited = new bool[a.Length];
            bool[] digits = new bool[10];
 
            foreach (int d in a.Select(c => c - '0'))
            {
                if (digits[d]) { return false; }
                digits[d] = true;
            }
 
            int index = 0;
            while (!visited[index])
            {
                visited[index] = true;
                index = ((index + (a[index] - '0')) % a.Length);
            }

            return visited.All(b => b) && index == 0;
        }
} 
