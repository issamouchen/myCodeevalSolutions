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
            if (IsValidNumber(line))
                        Console.WriteLine("1");
                    else 
                        Console.WriteLine("0");
        }
    }
    
        private static bool IsValidNumber(string line)
        {
            String numberStr = line.Replace(" ",""); 
            double totalsum = 0;

            for (int i = numberStr.Length - 1; i > -1 ; i--)
                {
                    if (((i - numberStr.Length) % 2) == 0)
                    { 
                        double doubleVal = char.GetNumericValue(numberStr[i]) * 2;
                        double sum = 0;
                        if (doubleVal > 9)
                        {
                            sum = char.GetNumericValue(doubleVal.ToString()[0]) + char.GetNumericValue(doubleVal.ToString()[1]);
                        }
                        else
                        {
                            sum = doubleVal;
                        }

                        totalsum += sum;
                    }
                    else
                    {
                        totalsum += char.GetNumericValue(numberStr[i]);
                    }
                }  

            if (totalsum % 10 == 0)
                return true;
            else
                return false;

        }
} 
