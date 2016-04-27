 using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         int[,] matrix = new int[256, 256];
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
            string[] theQuery;
                    char[] separator = new char[] { ' ' };
                    int value, row, col, sum = 0;


                    theQuery = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    string query = theQuery[0];

                    switch (query)
                    {
                        case "SetRow":
                            row = Convert.ToInt32(theQuery[1]);
                            value = Convert.ToInt32(theQuery[2]);

                            for (int cols = 0; cols < matrix.GetLength(1); cols++)
                            {
                                matrix[row, cols] = value;
                            }
                            break;
                        case "SetCol":
                            col = Convert.ToInt32(theQuery[1]);
                            value = Convert.ToInt32(theQuery[2]);

                            for (int rows = 0; rows < matrix.GetLength(0); rows++)
                            {
                                matrix[rows, col] = value;
                            }
                            break;
                        case "QueryRow":
                            row = Convert.ToInt32(theQuery[1]);

                            for (int cols = 0; cols < matrix.GetLength(1); cols++)
                            {
                                sum += matrix[row, cols];
                            }

                            Console.WriteLine(sum);
                            sum = 0;
                            break;
                        case "QueryCol":
                            col = Convert.ToInt32(theQuery[1]);

                            for (int rows = 0; rows < matrix.GetLength(0); rows++)
                            {
                                sum += matrix[rows, col];
                            }

                            Console.WriteLine(sum);
                            sum = 0;
                            break;
                        default:
                            Console.WriteLine("error!");
                            break;
                    }
        }
    }
} 
