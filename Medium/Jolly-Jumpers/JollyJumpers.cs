  using System;
using System.Linq;
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
            
                    int[] numbers = line.Split(' ').Select(int.Parse).ToArray();
                    int n = numbers[0] - 1;
                    int[] counts = new int[n];
                      
                    bool jolly = true;
                    for (int i = 2; i < numbers.Length; i++)
                    {
                        int dif = Math.Abs(numbers[i - 1] - numbers[i]);
                        if (dif > 0 && dif <= n)
                        {
                            counts[dif - 1]++;
                            if (counts[dif - 1] > 1)
                            {
                                jolly = false;
                                break;
                            }
                        }
                        else
                        {
                            jolly = false;
                            break;
                        }
                    }

                    Console.WriteLine(jolly ? "Jolly" : "Not jolly");
        }
    }
} 
