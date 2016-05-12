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
             int number = int.Parse(line);
                    Console.WriteLine(IntegerToBijectiveBase26(number));
        }
    }
    static string IntegerToBijectiveBase26(int number)
        {
            var stack = new Stack<char>();
            while (number > 0)
            {
                // Transform Quotient into 0-25 Range
                number = number - 1;
                char c = (char)('A' + (number % 26));
                number = number / 26;
                stack.Push(c);
            }

            var sb = new StringBuilder(stack.Count);
            foreach (var c in stack) { sb.Append(c); }
            return sb.ToString();
        }
} 
