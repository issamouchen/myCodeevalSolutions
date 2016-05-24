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
            var split = line.Split(';');
                var output = new char[split.Length];

                for (int i = 0; i < split.Length; i++)
                {
                    output[i] = numValues[split[i]];
                }

                Console.WriteLine(new string(output));
        }
    }
    static readonly Dictionary<string, char> numValues = new Dictionary<string, char>()
        {
            {"zero", '0'}, {"one", '1'}, {"two", '2'}, {"three", '3'}, {"four", '4'}, {"five", '5'}, {"six", '6'}, {"seven", '7'},{"eight", '8'}, {"nine", '9'}
        };

} 
