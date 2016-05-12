using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines(args[0]);
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
             var matchingBraces = new Dictionary<char, char>() { { '(', ')' }, { '{', '}' }, { '[', ']' } };
                var openBraces = new Stack<char>();
                bool valid = true;

                foreach (var c in line)
                {
                    if (matchingBraces.ContainsKey(c))
                    { 
                        openBraces.Push(c);
                    }
                    else if (matchingBraces.ContainsValue(c))
                    { 
                        if (openBraces.Count > 0)
                        {
                            char lastOpenBrace = openBraces.Pop();
                            if (c != matchingBraces[lastOpenBrace])
                            {
                                valid = false;
                                break;
                            }
                        }
                        else
                        {
                            valid = false;
                            break;
                        }
                    }
                }
 
                if (openBraces.Count != 0)
                {
                    valid = false;
                }

                Console.WriteLine(valid ? "True" : "False");
        }
    }
} 
