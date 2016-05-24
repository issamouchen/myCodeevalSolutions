
using System;
using System.IO;
using System.Text;
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
             string[] split = line.Split(';');
                string[] words = split[0].Split(' ');
                string[] output = new string[words.Length];
                int[] indexes = split[1].Split(' ').Select(int.Parse).ToArray();
                for (int i = 0; i < words.Length; i++)
                {
                     int outputIndex = -1;
                    if (i < indexes.Length) 
                    {
                        outputIndex = indexes[i] - 1;
                    }
                    else
                    {
                        for (int j = 0; j < output.Length; j++) 
                        {
                            if (output[j] == null) 
                            {
                                outputIndex = j;
                                break;
                            }
                        }
                    }

                    output[outputIndex] = words[i];
                }

                var sb = new StringBuilder(split[0].Length + 1);
                foreach (var word in output)
                {
                    sb.AppendFormat("{0} ", word);
                }

                Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
} 
