using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
                    string mytrimline = line.Trim();
                    int[] array_converted_line = new int[mytrimline.Length];
                    array_converted_line = ConvertStringToArray(mytrimline);

                    if (isSelfDesc(array_converted_line))
                    {
                        Console.WriteLine('1');
                    }
                    else
                    {
                        Console.WriteLine('0');
                    }
        }
    }
    
        protected static bool isSelfDesc(int[] numArray)
        {
            Boolean isSelfDec = true;

            if (numArray.Length == 1)
            {
                if (numArray[0] == 0)
                    isSelfDec= false;
                else
                    isSelfDec= true;
            }
            else
            {
                for (int i = 0; i < numArray.Length; i++)
                {
                    if (digitInArray(numArray, i) != numArray[i])
                    {
                        isSelfDec= false;
                    }
                }
            }

            return isSelfDec;
        }

        public static int digitInArray(int[] thearray, int x)
        {
            int counter = 0;
            foreach (int i in thearray)
            {
                if (i == x)
                {
                    counter++;
                }
            }

            return counter;
        }

        private static int[] ConvertStringToArray(string line)
        {
            int[] toreturn = line.Select(n => (int)Char.GetNumericValue(n)).ToArray();
            return toreturn;
        }
} 
