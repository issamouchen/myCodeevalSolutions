
using System;
using System.IO;
using System.Text;

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
            StringBuilder sb = new StringBuilder();
                bool newWord = false;
                bool firstWord = true;

                foreach (char c in line)
                { 
                    if (Char.IsLetter(c))
                    { 
                        if (newWord && !firstWord) { sb.Append(' '); }

                        sb.Append(Char.ToLower(c));
                        firstWord = false;
                        newWord = false;
                    }
                    else 
                    {
                        newWord = true;
                    }
                }

                Console.WriteLine(sb.ToString());
        }
    }
} 
