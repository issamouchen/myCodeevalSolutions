
using System;
using System.IO;
using System.Text;
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
            var split = line.Split('|');
                int[][] matrix = new int[split.Length][];

                for (int i = 0; i < split.Length; i++)
                {
                    matrix[i] = Array.ConvertAll(split[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                }
 
                int sortByRow = FindStartRow(matrix);
                if (sortByRow != -1) { SelectionSort(matrix, sortByRow); }
 
                Console.WriteLine(MatrixToString(matrix));
        }
    }
    static string MatrixToString(int[][] matrix)
        {
            var sb = new StringBuilder();
            foreach (var row in matrix)
            {
                foreach (var col in row)
                {
                    sb.Append(col).Append(' ');
                }

                sb.Append('|').Append(' ');
            }
 
            return sb.ToString(0, sb.Length - 3);
        }
        static void SelectionSort(int[][] matrix, int sortByRow)
        {
            int[] data = matrix[sortByRow];
            for (int i = 0; i < data.Length - 1; i++)
            { 
                int minIndex = i;
 
                for (int j = i + 1; j < data.Length; j++)
                { 
                    if (data[j] <= data[minIndex]) { minIndex = j; }
                }
 
                if (minIndex != i) { SwapColumn(matrix, i, minIndex); }
            }
        }
          static void SwapColumn(int[][] matrix, int a, int b)
        {
            foreach (var row in matrix)
            {
                int temp = row[a];
                row[a] = row[b];
                row[b] = temp;
            }
        }
        static int FindStartRow(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j - 1] != matrix[i][j]) { return i; }
                }
            }
 
            return -1;
        }
} 
