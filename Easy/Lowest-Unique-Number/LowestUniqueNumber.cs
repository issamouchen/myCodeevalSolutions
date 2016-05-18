using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
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
            string[] input = line.Split(' ');
                var counts = new Dictionary<string, int>();
                foreach (var num in input)
                {
                    if (!counts.ContainsKey(num)) { counts.Add(num, 0); }
                    counts[num]++;
                }
 
                string lowestUnique = String.Empty;
                foreach (var kvp in counts.OrderBy(kvp => kvp.Key))
                {
                    if (kvp.Value == 1)
                    {
                        lowestUnique = kvp.Key;
                        break;
                    }
                }
 
                int index = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == lowestUnique)
                    {
                        index = i + 1;
                        break;
                    }
                }

                Console.WriteLine(index.ToString());
        }
    }
} 
