
using System;
using System.IO;
using System.Text;

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
             int[] letterCounts = new int[26];
 
                for (int i = 0; i < line.Length; i++)
                { 
                    char c = (char)(line[i] | 32);
                    if (c >= 'a' && c <= 'z') { letterCounts[c - 'a']++; }
                }
 
                var sb = new StringBuilder();
                for (int i = 0; i < letterCounts.Length; i++)
                {
                    if (letterCounts[i] == 0) { sb.Append((char)('a' + i)); }
                }

                Console.WriteLine(sb.Length > 0 ? sb.ToString() : "NULL");
        }
    }
} 
