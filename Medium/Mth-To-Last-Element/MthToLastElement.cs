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
             string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
 
                int length = split.Length - 1;
                int index = int.Parse(split[length]);
 
                if (index > 0 && length - index >= 0)
                {
                    string element = split[length - index];
                    Console.WriteLine(element);
        }
    }
} 
    
}
