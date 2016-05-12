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
            var openBraces = new Stack<char>();
                    int wildcards = 0;
                    bool valid = true;

                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                         
                        if (c == ':' && i + 1 < line.Length)
                        {
                            if (line[i + 1] == '(' || line[i + 1] == ')')
                            {
                                wildcards++;
                            }
                        }
                        else if (c == '(')
                        { 
                            openBraces.Push(c);
                        }
                        else if (c == ')')
                        { 
                            if (openBraces.Count > 0) { openBraces.Pop(); }
                            else if (wildcards > 0) { wildcards--; }
                            else
                            {
                                valid = false;
                                break;
                            }
                        }
                    }
                     
                    if (openBraces.Count - wildcards > 0) { valid = false; }

                    Console.WriteLine(valid ? "YES" : "NO");
        }
    }
} 
