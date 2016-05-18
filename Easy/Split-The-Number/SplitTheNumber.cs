  using System;
 
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
            var operators = new char[] { '+', '-' };
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
            var split = line.Split(' ');
                int opIndex = split[1].IndexOfAny(operators);
                int n0 = int.Parse(split[0].Substring(0, opIndex));
                int n1 = int.Parse(split[0].Substring(opIndex));
                int result = 0;

                switch (split[1][opIndex])
                {
                    case '+':
                    result = n0 + n1;
                    break;

                    case '-':
                    result = n0 - n1;
                    break;
                }

                Console.WriteLine(result);
        }
    }
} 
