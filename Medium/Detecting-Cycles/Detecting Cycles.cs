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
            int[] sequence = Array.ConvertAll(line.Split(' '), int.Parse);
                int[] cycle = FloydsCycleDetection(sequence, 0);

                StringBuilder sb = new StringBuilder();
                foreach (var item in cycle) { sb.AppendFormat("{0} ", item); }
                Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
    static int[] FloydsCycleDetection(int[] sequence, int startIndex)
        {
            int l = sequence.Length;
            int tortoise = startIndex + 1; // f(x0) is the element/node next to x0.
            int hare = startIndex + 2;
            while (tortoise < l && sequence[tortoise] != sequence[hare])
            {
                tortoise += 1;
                hare = hare + 2 < l ? hare + 2 : hare;
            }
             int mu = 0;
            tortoise = startIndex;
            while (hare < l && sequence[tortoise] != sequence[hare])
            { 
                tortoise += 1;
                hare += 1;
                mu += 1;
            }
            int lam = 1;
            hare = tortoise + 1;
            while (hare < l && sequence[tortoise] != sequence[hare])
            {
                hare += 1;
                lam += 1;
            }
 
            int[] cycle = new int[lam];
            Array.Copy(sequence, mu, cycle, 0, lam); 
            return cycle;
        }
} 
