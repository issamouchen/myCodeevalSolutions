
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
            var sb = new StringBuilder();
                char prev = '\0';
                foreach (char c in line)
                {
                    if (c != prev)
                    {
                        sb.Append(c);
                        prev = c;
                    }
                }

                Console.WriteLine(sb.ToString());
        }
    }
} 
