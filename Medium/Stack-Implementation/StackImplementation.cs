
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
            string[] split = line.Split(' ');
                StringBuilder sb = new StringBuilder();
                 for (int i = split.Length - 1; i >= 0; i -= 2) { sb.AppendFormat("{0} ", split[i]); }
                  Console.WriteLine(sb.ToString(0, sb.Length - 1));
        }
    }
    class Stack<T>
        {
            private T[] data = new T[0];
            private const int defaultCapacity = 4;
            private int count = 0;
            public int Count { get { return count; } }

            public void Clear()
            {
                Array.Clear(data, 0, count);
                count = 0;
            }

            public void Push(T item)
            { 
                if (count == data.Length)
                {
                    T[] newStorage = new T[data.Length > 0 ? data.Length * 2 : defaultCapacity];
                    Array.Copy(data, newStorage, data.Length);
                    data = newStorage;
                }

                data[count++] = item;
            }

            public T Pop()
            { 
                if (count == 0) { throw new InvalidOperationException("Stack is empty"); }

                T item = data[--count];
                data[count] = default(T);
                return item;
            }
        }
} 
