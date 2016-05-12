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
             int targetDepth = int.Parse(line);
                int count = GausSum(targetDepth);
                var triangle = new int[count];
 
                triangle[0] = 1;
                int depth = 2;
                int c = 0;
                for (int i = 1; i < count; i++)
                {
                    
                    int leftIndex = i - depth;
                    int rightIndex = i - (depth - 1);
 
                    int sum = 0;
                    if (leftIndex > (GausSum(depth - 2) - 1)) { sum += leftIndex >= 0 ? triangle[leftIndex] : 0; }
                    if (rightIndex <= (GausSum(depth - 1) - 1)) { sum += rightIndex >= 0 ? triangle[rightIndex] : 0; }
                    triangle[i] = sum;
 
                    if (++c == depth)
                    {
                        depth++;
                        c = 0;
                    }
                }

                for (int i = 0; i < triangle.Length; i++)
                {
                    if (i != triangle.Length - 1) { Console.Write("{0} ", triangle[i]); }
                    else { Console.WriteLine(triangle[i]); }
                }
        }
    }
    static int GausSum(int n) { return (n * (n + 1)) / 2; }
         

}
