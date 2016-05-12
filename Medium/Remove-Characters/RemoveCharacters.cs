using System;
using System.IO;
using System.Text.RegularExpressions;

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
            string[] split = line.Split(',');
                string pattern = "[" + split[1].Trim() + "]";
                string text = Regex.Replace(split[0], pattern, String.Empty).Trim();
                Console.WriteLine(text);
        }
    }
} 
