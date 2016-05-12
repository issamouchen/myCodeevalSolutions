 using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         
            int biggestPrimePalindrome = BiggestPrimePalindrome(1000);
            Console.WriteLine(biggestPrimePalindrome);
        
    }
     static int BiggestPrimePalindrome(int n)
        {
            var primes = new List<int>(n) { 2 };
 
            for (int i = 3; i <= n; i += 2)
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
 
            for (int i = primes.Count - 1; i >= 0; i--)
            {
                if (IsPalindrome(primes[i])) { return primes[i]; }
            }

            return -1;
        }
        static bool IsPalindrome<T>(T input)
        {
            string candidate = input.ToString();
            for (int i = 0; i < candidate.Length / 2; i++)
            {
                if (candidate[i] != candidate[candidate.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

} 
