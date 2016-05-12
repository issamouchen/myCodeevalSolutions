using System;
using System.Text;
using System.IO;
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
            
                    Console.WriteLine(FindFirstNonRepeatedCharacter(line));
        }
    }
    
        static char FindFirstNonRepeatedCharacter(string line)
        {
            var counts = new Dictionary<char, int>();
             
            foreach (char c in line)
            {
                if (!counts.ContainsKey(c)) { counts.Add(c, 1); }
                else { counts[c]++; }
            }
             
            return (from kvp in counts where kvp.Value == 1 select kvp.Key).FirstOrDefault();
        }
} 
