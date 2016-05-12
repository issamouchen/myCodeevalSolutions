 using System;
using System.Text;
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
             string[] split = line.Split(' ');
                int modA = int.Parse(split[0]);
                int modB = int.Parse(split[1]);
                int max = int.Parse(split[2]);
                StringBuilder sb = new StringBuilder();

                for (int num = 1; num <= max; num++)
                {
                    if (num % modA == 0 && num % modB == 0) { sb.Append("FB"); }
                    else if (num % modA == 0) { sb.Append("F"); }
                    else if (num % modB == 0) { sb.Append("B"); }
                    else { sb.Append(num); }
 
                    if (num != max) { sb.Append(" "); }
                }

                Console.WriteLine(sb.ToString());
        }
    }
} 
