
using System;
using System.Collections.Generic;
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
            uint n = uint.Parse(line);
                CalculatePrimesDynamic(n);
 
                var sb = new StringBuilder(primes.Count * 2);
                foreach (var prime in primes)
                {
                    if (prime < n) { sb.AppendFormat("{0},", prime); }
                    else { break; }
                }

                Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
     static List<uint> primes = new List<uint>() { 2, 3, 5, 7, 11 };
     static void CalculatePrimesDynamic(uint n)
        { 
            for (uint i = primes[primes.Count - 1] + 2; i <= n; i += 2)
            {
                bool isPrime = true;
                int upperLimit = (int)Math.Sqrt(i);
                
                for (int j = 0; primes[j] <= upperLimit; j++)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) { primes.Add(i); }
            }
        }
} 
