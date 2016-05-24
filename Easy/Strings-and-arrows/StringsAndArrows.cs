 
using System;
using System.IO;
using System.Text;

class Program
{
     
    static void Main(string[] args)
    {
            char[] alphabet = new char[] { '>', '-', '<' };
            string[] patterns = new string[] { ">>-->", "<--<<" };
            
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
            Console.WriteLine(
                    NaiveStringSearch(line, patterns[0]) + 
                    NaiveStringSearch(line, patterns[1])
                );
        }
    }
     public static int NaiveStringSearch(string text, string pattern)
        {
            int count = 0;

            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                int j;
                for (j = 0; j < pattern.Length; j++)
                {
                    if (text[i + j] != pattern[j]) { break; }
                }

                if (j == pattern.Length) { count++; }
            }

            return count;
        }
} 
