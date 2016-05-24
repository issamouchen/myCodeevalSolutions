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
            var nums = Array.ConvertAll(line.Split(','), int.Parse);
                Console.WriteLine(MaxSum(nums));
        }
    }
    static int MaxSum(int[] nums)
        { 
            if (nums.Length <= 0) { return 0; }
 
            int maxSoFar = nums[0];
            int maxEndingHere = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
} 
