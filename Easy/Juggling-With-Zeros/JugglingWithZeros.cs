
using System;
using System.IO;


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
                ulong sum = 0;

                for (int i = 0; i < split.Length; i += 2)
                {
                    string flag = split[i];
                    string elements = split[i + 1];
 
                    if (flag == "0")
                    { 
                        sum = sum << elements.Length;
                    }
                    else if (flag == "00")
                    {
                        for (int j = 0; j < elements.Length; j++)
                        { 
                            sum = sum << 1;
                            sum = sum | 1;
                        }
 
                    }
                }

                Console.WriteLine(sum);
        }
    }
} 
