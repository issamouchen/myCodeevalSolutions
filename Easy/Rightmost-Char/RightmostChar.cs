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
             var split = line.Split(',');
                        string sentence = split[0];
                        char characterToFind = split[1][0];
 
                        Console.WriteLine(sentence.LastIndexOf(characterToFind));
        }
    }
} 
