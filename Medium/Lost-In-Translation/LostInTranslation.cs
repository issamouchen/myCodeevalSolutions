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
            
                    char[] mapA = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }; // v x
                    char[] mapB = new char[] { 'y', 'n', 'f', 'i', 'c', 'w', 'l', 'b', 'k', 'u', 'o', 'm', 'x', 's', 'e', 'v', 'z', 'p', 'd', 'r', 'j', 'g', 't', 'h', 'a', 'q' }; //g h

                    char[] resultChar = new char[line.Length];
                   

                    for (int i = 0; i < line.Length; i++)
                    {

                            for(int j=0;j <mapB.Length;j++){
                                if(line[i]==mapB[j])
                                {
                                    resultChar[i] = mapA[j];
                                } 
                            } 
                    }

                    string result = new string(resultChar);

                    result = result.Replace("\0", " ");

                    Console.WriteLine(result);
        }
    }
} 
