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
            
             for (int i = 1; i <= line.Length; i++)
                    {
                        Char[] sub = line.Substring(0, i).ToCharArray();

                        String[] lineArray = line.Split(sub);

                        bool allSplitElementsEmpty = true;
                        foreach (String s in lineArray)
                        {
                            if (s.Length > 0)
                            {
                                allSplitElementsEmpty = false;
                                break;
                            }
                        }

                        if (allSplitElementsEmpty)
                        {
                            Console.WriteLine(sub.Length);
                            break;
                        }
                    }
        }
    }
} 
