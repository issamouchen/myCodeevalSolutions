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
                var words = line.Split(' ');
                string largestWord = String.Empty;
 
                foreach (var word in words)
                {
                    if (word.Length > largestWord.Length) { largestWord = word;}
                }
 
                for (int i = 0; i < largestWord.Length; i++)
                {
                    sb.AppendFormat("{0}{1} ", new String('*', i), largestWord[i]);
                }
                 
                Console.WriteLine(sb.ToString(0, sb.Length - 1));
                
        }
    }
} 
