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
            string[] split = line.Split(',');
                bool result = IsRotation(split[0], split[1]);
                Console.WriteLine(result ? "True" : "False");
        }
    }
     private static bool IsRotation(string s1, string s2)
        {
            return FindRotationOffset(s1, s2) >= 0;
        }
         private static int FindRotationOffset(string s1, string s2)
        { 
            if (s1.Length != s2.Length) { return -1; }
 
            for (int offset = 0; offset < s1.Length; offset++)
            {
                bool isRotation = true;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[(i + offset) % s1.Length])
                    {
                        isRotation = false;
                        break;
                    }
                }

                if (isRotation) { return offset; }
            }

            return -1;
        }
} 
