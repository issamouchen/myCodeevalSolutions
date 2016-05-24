
using System;
using System.Globalization;
using System.IO;
using System.Linq;
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
            if (String.IsNullOrEmpty(line))
                {
                    Console.WriteLine("lowercase: {0} uppercase: {1}", 0.ToString("F2", CultureInfo.InvariantCulture), 0.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                }
                int total = line.Length;
                double lower = line.Count(c => c >= 'a' && c <= 'z');
                double upper = total - lower;
                 Console.WriteLine("lowercase: {0} uppercase: {1}", (lower / total * 100).ToString("F2", CultureInfo.InvariantCulture), (upper / total * 100).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
} 
