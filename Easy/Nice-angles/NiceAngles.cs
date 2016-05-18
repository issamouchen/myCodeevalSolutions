using System;
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
             double number = double.Parse(line);
                int angle = (int)number;

                number = (number - angle) * 60;
                int minute = (int)number;

                number = (number - minute) * 60;
                int seconds = (int)number;

                Console.WriteLine("{0}.{1:D2}'{2:D2}\"", angle, minute, seconds);
        }
    }
} 
