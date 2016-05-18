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
            // do something with lin
            var split = line.Split(';');
                int days = int.Parse(split[0]);
                var nums = Array.ConvertAll(split[1].Split(' '), int.Parse);
                Console.WriteLine(MaxSumForPeriod(nums, days)); 
        }
    }
    static int MaxSum(int[] nums)
        { 
            int maxSoFar = 0;
            int maxEndingHere = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                maxEndingHere = Math.Max(0, maxEndingHere + nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
        static int MaxSumForPeriod(int[] nums, int period)
        { 
            int sumForPeriod = 0;
            int maxSumForPeriod = 0;
 
            if (period > nums.Length) { return 0; }
            for (int i = 0; i < period; i++)
            {
                sumForPeriod += nums[i];
                maxSumForPeriod = sumForPeriod;
            }
 
            for (int i = period; i < nums.Length; i++)
            {
                int first = i - period;
                sumForPeriod -= nums[first];
                sumForPeriod += nums[i];
                maxSumForPeriod = Math.Max(maxSumForPeriod, sumForPeriod);
            }
 
            return Math.Max(0, maxSumForPeriod);
        }

} 
