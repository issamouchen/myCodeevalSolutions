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
            string[] split = line.Split(';');

                int startIndex = split[0].IndexOf(' ') + 1;
                int length = split[0].Length - startIndex;
                var center = new Vector2D(split[0].Substring(startIndex, length));

                startIndex = split[1].LastIndexOf(' ') + 1;
                length = split[1].Length - startIndex;
                double radius = double.Parse(split[1].Substring(startIndex, length));

                startIndex = split[2].IndexOf(' ', 1) + 1;
                length = split[2].Length - startIndex;
                var point = new Vector2D(split[2].Substring(startIndex, length));
 
                Vector2D target = point - center;
 
                Console.WriteLine(target.Magnitude < radius ? "true" : "false");
        }
    }
    struct Vector2D
        {
            public double x;
            public double y;
            public double Magnitude { get { return Math.Sqrt(x * x + y * y); } }

            public Vector2D(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
 
            public Vector2D(string input) 
            {
                int mid = input.IndexOf(',');
                x = double.Parse(input.Substring(1, mid - 1));
                y = double.Parse(input.Substring(mid + 2, input.Length - (mid + 2 + 1)));
            }
 
            public static Vector2D operator-(Vector2D v1, Vector2D v2 )
            {
                return new Vector2D(v1.x - v2.x, v1.y - v2.y);
            }

            public static Vector2D operator+(Vector2D v1, Vector2D v2 )
            {
                return new Vector2D(v1.x + v2.x, v1.y + v2.y);
            }
        }

} 
