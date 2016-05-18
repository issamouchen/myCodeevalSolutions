using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
         string[] slang = new[]
            {
                ", yeah!",
                ", this is crazy, I tell ya.",
                ", can U believe this?",
                ", eh?",
                ", aw yea.",
                ", yo.",
                "? No way!",
                ". Awesome!"
            };

            int slangIndex = 0;
            int slangCount = slang.Length;
            bool substitue = false;
            
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
            StringBuilder sb = new StringBuilder();
                foreach (char c in line)
                { 
                    if (c == '.' || c == '!' || c == '?')
                    {
                        if (substitue) { sb.Append(slang[slangIndex++]); }
                        else { sb.Append(c); }
                        
                        substitue = !substitue;
                        slangIndex = slangIndex % slangCount;
                    }
                    else { sb.Append(c); }
                }

                Console.WriteLine(sb.ToString());
        }
    }
} 
