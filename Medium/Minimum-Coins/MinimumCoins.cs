using System;
using System.Collections.Generic;  
using System.IO; 
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
            

                    int total = Convert.ToInt32(line);

                    Console.WriteLine(findMinCoins(new int[]{1, 3, 5},total,0,0));
        }
    }
    
        static int findMinCoins(int[] coins, int sum, int index, int count)
        {
            if (sum == 0)
            {
                return count;
            }
            if (index == coins.Count())
            {
                return 0;
            }
            if (sum < 0)
            {
                return 0;
            }
            int countUsingIndex = findMinCoins(coins, sum - coins[index], index, count + 1);
            int countWithoutUsingIndex = findMinCoins(coins, sum, index + 1, count);
            if (countUsingIndex == 0)
            {
                return countWithoutUsingIndex;
            }
            if (countWithoutUsingIndex == 0)
            {
                return countUsingIndex;
            }
            return Math.Min(countUsingIndex, countWithoutUsingIndex);
        }
} 
