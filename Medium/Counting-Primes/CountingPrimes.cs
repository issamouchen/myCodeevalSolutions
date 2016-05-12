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
             var split = line.Split(',');
                    uint n = uint.Parse(split[0]);
                    uint m = uint.Parse(split[1]);
                     
                    CalculatePrimesDynamic(m);
                    int sum = CountPrimes(n, m);
                    Console.WriteLine(sum);
        }
    }
    
        static int CountPrimes(uint n, uint m)
        {
            int leftIndex = BinarySearch.FindIndex(primes, n, BinarySearch.FindType.EqualOrMore);
            int rightIndex = BinarySearch.FindIndex(primes, m, BinarySearch.FindType.EqualOrLess);
            int sum = (rightIndex - leftIndex) + 1;

            return sum;
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
        static class BinarySearch
        { 
            internal enum FindType { EqualOrMinusOne, EqualOrLess, EqualOrMore };
             
            internal static int FindIndex<T>(IList<T> data, T element, FindType findType = FindType.EqualOrMinusOne) { return FindIndex(data, element, Comparer<T>.Default, findType); }
            internal static int FindIndex<T>(IList<T> data, T element, Comparer<T> comparer, FindType findType)
            { 
                if (data.Count < 1) { return -1; }
                else if (comparer.Compare(element, data[0]) < 0) { return findType == FindType.EqualOrMore ? 0 : -1; }
                else if (comparer.Compare(element, data[data.Count - 1]) > 0) { return findType == FindType.EqualOrLess ? data.Count - 1 : -1; }
                 
                int minIndex = 0;
                int maxIndex = data.Count - 1;

                while (minIndex <= maxIndex)
                {
                    int midIndex = (minIndex + maxIndex) / 2;
                    int c = comparer.Compare(element, data[midIndex]);

                    if (c == 0) { return midIndex; } 
                    else if (c > 0) { minIndex = midIndex + 1; } 
                    else if (c < 0) { maxIndex = midIndex - 1; } 
                }
                 
                switch (findType)
                {
                    case FindType.EqualOrLess:
                        return maxIndex;

                    case FindType.EqualOrMore:
                        return minIndex;

                    case FindType.EqualOrMinusOne:
                    default:
                        return -1;
                }
            }
        }

} 
