
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
            int i = 0;
                int sum = int.Parse(line);
                while (!IsPalindrome(sum) && i < 99)
                {
                    sum += Reverse(sum);
                    i++;
                }

                Console.WriteLine("{0} {1}", i, sum);
        }
    }
      static bool IsPalindrome(int input) { return input == Reverse(input); }
       static int Reverse(int number)
        {
            int reverse = 0;
            while (number != 0)
            { 
                int remainder = number % 10;
                number = number / 10;
                reverse = reverse * 10 + remainder;
            }

            return reverse;
        }

} 
