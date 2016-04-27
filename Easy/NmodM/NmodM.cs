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
            
             int n, m, result;

                    n = Convert.ToInt32(line.Split(",".ToCharArray())[0]);
                    m = Convert.ToInt32(line.Split(",".ToCharArray())[1]);

                    result = mod(n, m);

                    Console.WriteLine(result);
        }
    }
    
        static int mod(int a, int n)
        {
            int result = a % n;
            if ((a < 0 && n > 0) || (a > 0 && n < 0))
                result += n;
            return result;
        }
    
    
} 
