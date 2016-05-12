 
using System;
using System.IO;
using System.Text;
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
                bool happyNumber = false;
                int i = 1000;
                while (!happyNumber && i-- > 0)
                { 
                    number = SquareDigits(number);
                    if (number == 1) { happyNumber = true; }
                }

                Console.WriteLine(happyNumber ? 1 : 0);
        }
    }
    static int SquareDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                number = number / 10;
                sum += digit * digit;
            }

            return sum;
        }
} 
