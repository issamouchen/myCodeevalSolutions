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
            var split = Array.ConvertAll(line.Split(' '), int.Parse);
                    int doors = split[0];
                    int iterations = split[1];
                    int locked = 0;

                    if (iterations <= 1)
                    {
                        locked = 1;
                    }
                    else
                    { 
                        iterations--;
                         
                        locked = doors / 2;
                         
                        if (iterations % 2 != 0) { locked += doors / 3 - doors / 6; }
                         
                        locked -= doors / 6;
                         
                        if (doors % 6 == 0) { locked++; }
                        else if (doors % 2 == 0) { locked--; }
                        else if (doors % 3 == 0)
                        { 
                            if (iterations % 2 != 0) { locked--; }
                            else { locked++; }
                        }
                        else
                        {
                            locked++;
                        } 
                    }

                    System.Console.WriteLine(doors - locked);
        }
    }
} 
