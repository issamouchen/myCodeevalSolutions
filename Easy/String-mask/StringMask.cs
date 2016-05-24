
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
             string[] split = line.Split(' ');
                var sb = new StringBuilder(split[0]);
                for (int i = 0; i < split[0].Length; i++)
                {
                    if (split[1][i] == '1')
                    {
                        sb[i] = Char.ToUpper(sb[i]);
                    }
                }

                Console.WriteLine(sb.ToString());
        }
    }
} 
