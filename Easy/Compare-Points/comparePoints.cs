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
            string[] coordinates = line.Split(" ".ToCharArray());
                    string result="";

                    int x, y, q, r;

                    x = Convert.ToInt32(coordinates[0]);
                    y = Convert.ToInt32(coordinates[1]);
                    q = Convert.ToInt32(coordinates[2]);
                    r = Convert.ToInt32(coordinates[3]);

                    if (r - y < 0)
                    {
                        result += "S";
                    }
                    else if (r - y > 0)
                    {
                        result += "N";
                    }
                    if (q-x < 0)
                    {
                        result += "W";
                    }
                    else if (q-x > 0)
                    {
                        result += "E";
                    }
                    

                    if(result=="")
                    {
                        Console.WriteLine("here");
                    }
                    else
                    {
                        Console.WriteLine(result);
                    }
                    
        }
    }
} 
