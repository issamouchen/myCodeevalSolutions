
using System;
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
            
            int[] numbers = line.Split(' ').Skip(1).Select(int.Parse).OrderBy(x => x).ToArray();
 
                int mid = numbers.Length / 2;
                int median = numbers.Length % 2 == 0 ? (numbers[mid] + numbers[mid - 1]) / 2 : numbers[mid];
                int minDistance = numbers.Sum(num => Math.Abs(num - median));

                Console.WriteLine(minDistance);
        }
    }
}
