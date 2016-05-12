using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var fileInfo = new FileInfo(args[0]);
            Console.WriteLine(fileInfo.Length);
    }
} 
