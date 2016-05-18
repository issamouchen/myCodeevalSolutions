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
              string[] graph = File.ReadAllLines(args[0]);
            PrintPath(graph, FindPath(graph));
        }
    }
    private static int[] FindPath(string[] graph)
        {
            int[] path = new int[graph.Length];

            for (int i = 0; i < graph.Length; i++)
            { 
                int pos = graph[i].IndexOf('C');
                if (pos == -1) { pos = graph[i].IndexOf('_'); }
                path[i] = pos;
            }

            return path;
        }
        private static void PrintPath(string[] graph, int[] path)
        { 
            
             int prev = path[0];
            for (int i = 0; i < graph.Length; i++)
            {
                int cur = path[i];
                char dir = cur < prev ? '/' : cur > prev ? '\\' : '|';

                char[] line = graph[i].ToCharArray();
                line[path[i]] = dir;
                Console.WriteLine(line);

                prev = cur;
            }
        }
} 
