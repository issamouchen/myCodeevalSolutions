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
            if (!String.IsNullOrEmpty(line))
                    {
                        int number = int.Parse(line);
                        Console.WriteLine(IntegerToBinary(number));
                    }
        }
    }
    static string IntegerToBinary(int number)
        {
            // Exit early
            if (number == 0) { return "0"; }

            var stack = new Stack<int>();
            while (number > 0)
            {
                int remainder = number % 2;
                number = number / 2;
                stack.Push(remainder);
            }

            var sb = new StringBuilder(stack.Count);
            while (stack.Count > 0) { sb.Append(stack.Pop()); }

            return sb.ToString();
        }
} 
