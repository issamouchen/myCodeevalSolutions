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
            
                    Console.WriteLine(EvaluateChain(line) ? "GOOD" : "BAD");
        }
    }
    
        private static bool EvaluateChain(string chain)
        {
            var nodes = new Dictionary<string, string>();
             
            foreach (string pair in chain.Split(';'))
            { 
                var node = pair.Split('-');
                if (nodes.ContainsKey(node[0])) { return false; }   // Duplicate
                if (node[0].Equals(node[1])) { return false; }      // Cycle
                nodes.Add(node[0], node[1]);
            }
             
            string transitionTo = "BEGIN";
            for (int i = 0; i < nodes.Count; i++)
            {
                if (!nodes.ContainsKey(transitionTo)) { return false; }
                transitionTo = nodes[transitionTo];
            }
             
            return transitionTo.Equals("END");
        }
} 
