using System;
using System.Diagnostics;
using System.IO;
using System.Text;

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
             Console.WriteLine(ReturnValidPositions(line[0], line[1]));
        }
    }
    private static string ReturnValidPositions(char col, char row)
        { 
            Debug.Assert(col >= 'a' && col <= 'h');
            Debug.Assert(row >= '1' && row <= '8');
            var sb = new StringBuilder();
 
            if (col - 2 >= 'a' && row - 1 >= '1') { sb.Append((char)(col - 2)).Append((char)(row - 1)).Append(' '); }
            if (col - 2 >= 'a' && row + 1 <= '8') { sb.Append((char)(col - 2)).Append((char)(row + 1)).Append(' '); }
            if (col - 1 >= 'a' && row - 2 >= '1') { sb.Append((char)(col - 1)).Append((char)(row - 2)).Append(' '); }
            if (col - 1 >= 'a' && row + 2 <= '8') { sb.Append((char)(col - 1)).Append((char)(row + 2)).Append(' '); }
 
            if (col + 1 <= 'h' && row - 2 >= '1') { sb.Append((char)(col + 1)).Append((char)(row - 2)).Append(' '); }
            if (col + 1 <= 'h' && row + 2 <= '8') { sb.Append((char)(col + 1)).Append((char)(row + 2)).Append(' '); }
            if (col + 2 <= 'h' && row - 1 >= '1') { sb.Append((char)(col + 2)).Append((char)(row - 1)).Append(' '); }
            if (col + 2 <= 'h' && row + 1 <= '8') { sb.Append((char)(col + 2)).Append((char)(row + 1)).Append(' '); }
             
            return sb.ToString(0, sb.Length - 1);
        }
} 
