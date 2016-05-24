using System;
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
             int mid = line.IndexOf(')');
                Vector2D v1 = new Vector2D(line.Substring(0, mid + 1));
                Vector2D v2 = new Vector2D(line.Substring(mid + 2, line.Length - (mid + 2)));
                Vector2D target = new Vector2D(v2.x - v1.x, v2.y - v1.y);

                Console.WriteLine(target.Magnitude);
        }
    }
    struct Vector2D
        {
            public int x;
            public int y;
            public int Magnitude { get { return (int)Math.Sqrt(x * x + y * y); } }

            public Vector2D(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            // (25, 4)
            public Vector2D(string input) 
            {
                int mid = input.IndexOf(',');
                x = int.Parse(input.Substring(1, mid - 1));
                y = int.Parse(input.Substring(mid + 2, input.Length - (mid + 2 + 1)));
            }
        }
} 
