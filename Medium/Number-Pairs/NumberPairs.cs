using System;
using System.IO;
using System.Linq;
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
             string[] split = line.Split(';');
                int[] numbers = split[0].Split(',').Select(s => int.Parse(s)).ToArray();
                int target = int.Parse(split[1]);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] + numbers[j] == target)
                        { 
                            sb.AppendFormat("{0},{1};", numbers[i], numbers[j]);
                            break;
                        }
                    }
                }
 
                Console.WriteLine(sb.Length != 0 ? sb.ToString(0, sb.Length - 1) : "NULL");
        }
    }
} 
