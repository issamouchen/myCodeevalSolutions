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
            var rows = line.Split('|');
                var max = Array.ConvertAll(rows[0].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries), int.Parse);

                foreach (var row in rows)
                {
                    var col = row.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < col.Length; i++)
                    {
                        int val = int.Parse(col[i]);
                        if (val > max[i]) { max[i] = val; }
                    }
                }

                Console.WriteLine(String.Join(" ", max));
        }
    }
} 
