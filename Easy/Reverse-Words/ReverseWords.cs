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
            
                    string revLine = ReverseWords(line);
                    Console.WriteLine(revLine);

        }
    }
    
        private static String ReverseWords(string line)
        {
            string[] words = line.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
} 
