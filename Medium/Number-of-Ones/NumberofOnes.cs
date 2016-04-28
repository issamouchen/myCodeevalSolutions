 using System;
using System.Collections.Generic;  
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
            
                    int num = Convert.ToInt32(line);

                    string binary = Convert.ToString(num, 2);

                    int occurence = binary.Split('1').Length - 1;

                    Console.WriteLine(occurence.ToString());
        }
    }
} 
