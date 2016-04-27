using System;
using System.Linq;
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
            
                    string[] words = line.Split(" ".ToCharArray());

                    int longestLength = words.Max(w => w.Length);

                    var longestWords = from word in words where word.Length == longestLength select word;
                     
                    Console.WriteLine(longestWords.First());
        }
    }
} 
