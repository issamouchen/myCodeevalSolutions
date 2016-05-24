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
                foreach (string s in line.Split(' '))
                {
                    sb.Append(s[s.Length - 1]).Append(s, 1, s.Length - 2).Append(s[0]).Append(' ');
                }

                Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
} 
