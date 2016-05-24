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
            string[] split = line.Split(' ');
                int[] t1 = Array.ConvertAll(split[0].Split(':'), int.Parse);
                int[] t2 = Array.ConvertAll(split[1].Split(':'), int.Parse);

                int time1 = t1[0] * 60 * 60 + t1[1] * 60 + t1[2];
                int time2 = t2[0] * 60 * 60 + t2[1] * 60 + t2[2];
                int delta = time1 > time2 ? time1 - time2 : time2 - time1;
 
                int hours = delta / (60 * 60);
                delta = delta - hours * 60 * 60;
                int minutes = delta / 60;
                delta = delta - minutes * 60;
                int seconds = delta;
                Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
        }
    }
} 
