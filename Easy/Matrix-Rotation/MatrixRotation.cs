 using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
             int elementCount = line.Length - line.Count(c => c == ' ');
                int n = (int)Math.Sqrt(elementCount);
                Debug.Assert(n * n == elementCount, "matrix needs to be square");
                
                int elementIndex = 0;
                char[,] matrix = new char[n, n];
                for (int x = 0; x < n; x++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        matrix[x, y] = line[elementIndex];
                        elementIndex += 2;
                    }
                }
RotateMatrixRight(matrix);
                 StringBuilder sb = new StringBuilder(line.Length);
                for (int x = 0; x < n; x++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        sb.Append(matrix[x, y]);
                        if (x != n - 1 || y != n - 1) { sb.Append(' '); }
                    }
                }

                Console.WriteLine(sb.ToString());
        }
        
    }
    
     static void RotateMatrixRight<T>(T[,] m)
        {
            Debug.Assert(m.GetLength(0) == m.GetLength(1), "Matrix needs to be square");
            int n = m.GetLength(0);
            int f = n / 2;       // floor
            int c = (n + 1) / 2; // ceil

            for (int x = 0; x < f; x++)
            {
                for (int y = 0; y < c; y++)
                {
                    // Cyclic Roll
                    T temp = m[x, y];
                    m[x, y] = m[n - 1 - y, x];
                    m[n - 1 - y, x] = m[n - 1 - x, n - 1 - y];
                    m[n - 1 - x, n - 1 - y] = m[y, n - 1 - x];
                    m[y, n - 1 - x] = temp;
                }
            }
        }

        static void RotateMatrixRightSlow<T>(T[,] m)
        {
            TransposeMatrix(m);
            ReverseMatrixRows(m);
        }

        static void TransposeMatrix<T>(T[,] m)
        {
            Debug.Assert(m.GetLength(0) == m.GetLength(1), "Matrix needs to be square");
            int n = m.GetLength(0);

            for (int x = 0; x < n - 1; x++) {
                for (int y = x + 1; y < n; y++)
                {
                    T temp = m[x, y];
                    m[x, y] = m[y, x];
                    m[y, x] = temp;
                }
            }
        }

        static void ReverseMatrixRows<T>(T[,] m)
        {
            Debug.Assert(m.GetLength(0) == m.GetLength(1), "Matrix needs to be square");
            int n = m.GetLength(0);
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n / 2; y++)
                {
                    T temp = m[x, y];
                    m[x, y] = m[x, (n - 1) - y];
                    m[x, (n - 1) - y] = temp;
                }
            }
        }
} 
