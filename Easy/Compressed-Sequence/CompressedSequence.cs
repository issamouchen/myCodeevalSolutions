 using System;
using System.Linq; 
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
                String[] input;

                input = line.Split(" ".ToCharArray());

                    Console.WriteLine(printCompressedArray(input));
        } 
    }

         public static string printCompressedArray(String[] input)
        {
            string result = "";

            if ((input.Count() == 0)) {
                return "";
            }
        
            int currentNumber = Convert.ToInt32(input[0]);
            int currentCount = 1;
            for (int i = 1; (i < input.Count()); i++) {
                int number = Convert.ToInt32(input[i]);
                if ((number != currentNumber)) {
                    result += currentCount + (" " + (currentNumber + " ")) ;
                    currentNumber = number;
                    currentCount = 1;
                }
                else {
                    currentCount++;
                }
            
            }
            result += currentCount + (" " + (currentNumber + " "));

            return result;
        }
} 
