 using System;
using System.Collections.Generic;  
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
            
                    int n;

                    n = line.Length;

                    Console.WriteLine(countCombinations(line, n).ToString());
        }
    }
    static int countCombinations(string line, int n)
        {
            int[] count;
            count = new int[n + 1];

            count[0] = 1;
            count[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                count[i] = 0;

                if (line[i - 1] > '0')
                    count[i] = count[i - 1];

                if (line[i - 2] < '2' || (line[i - 2] == '2' && line[i - 1] < '7'))
                    count[i] += count[i - 2];
 
            }
     
            return count[n];

        } 
} 
