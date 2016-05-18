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
            string[] split = line.Split(',');
                var words = new StringBuilder();
                var numbers = new StringBuilder();

                // 2 Iterations or 2 output streams pick one
                foreach (var s in split)
                {
                    int c = s[0] - '0';
                    if (c >= 0 && c <= 9) { numbers.AppendFormat("{0},", s); }
                    else { words.AppendFormat("{0},", s); }
                }

                // Print the output
                if (words.Length > 0)
                {
                    if (numbers.Length > 0) { Console.WriteLine(string.Format("{0}|{1}", words.ToString(0, words.Length - 1), numbers.ToString(0, numbers.Length - 1))); }
                    else { Console.WriteLine(words.ToString(0, words.Length - 1)); }
                }
                else { Console.WriteLine(numbers.ToString(0, numbers.Length - 1)); }
        }
    }
} 
