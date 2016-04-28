	using System;
using System.Collections.Generic;  
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        int N = int.Parse("1000"), x = 1, o = 0, p = 0;
            while (x <= 1000)
            {
                p++;
                if (isPrime(p)) { o += p; x++; }
            }
            Console.WriteLine(o);
    }
    
    
        static bool isPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
                if (n % i == 0) return false;
            return true;
        }   
} 
