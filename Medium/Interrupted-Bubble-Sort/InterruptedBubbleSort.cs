 using System;
using System.Text;
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
                     
                    int[] numbers = new int[split.Length - 2];
                    ulong iterations = ulong.Parse(split[split.Length - 1]);
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = int.Parse(split[i]);
                    }

                    BubbleSort(numbers, iterations);
                     
                    var sb = new StringBuilder(line.Length);
                    foreach (var s in numbers)
                    {
                        sb.AppendFormat("{0} ", s);
                    }
                    Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
    
        static void Swap<T>(IList<T> data, int i, int j)
        {
            T temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
        static void BubbleSort<T>(IList<T> data, ulong iterations)
        { 
            IComparer<T> cmp = Comparer<T>.Default;

            bool sorted = false;
            while (!sorted && iterations-- > 0)
            {
                sorted = true;
                for (int i = 1; i < data.Count; i++)
                { 
                    if (cmp.Compare(data[i - 1], data[i]) > 0)
                    {
                        Swap(data, i - 1, i);
                        sorted = false;
                    }
                }
            }
        }
} 
