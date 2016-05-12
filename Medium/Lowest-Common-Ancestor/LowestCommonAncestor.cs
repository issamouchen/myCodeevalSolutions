using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree<int> bst = GenerateChallengeBst();
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
            var numbers = Array.ConvertAll(line.Split(' '), int.Parse);
 
                Console.WriteLine(bst.FindLowestCommonAncestor(numbers[0], numbers[1]).Value);
        }
    }
     private static BinarySearchTree<int> GenerateChallengeBst()
        {
            var bst = new BinarySearchTree<int>();
            bst.Root = new BinarySearchTree<int>.Node<int>(30);
            bst.Root.Left = new BinarySearchTree<int>.Node<int>(8);
            bst.Root.Left.Left = new BinarySearchTree<int>.Node<int>(3);
            bst.Root.Left.Right = new BinarySearchTree<int>.Node<int>(20);
            bst.Root.Left.Right.Left = new BinarySearchTree<int>.Node<int>(10);
            bst.Root.Left.Right.Right = new BinarySearchTree<int>.Node<int>(29);
            bst.Root.Right = new BinarySearchTree<int>.Node<int>(52);
            return bst;
        }
        class BinarySearchTree<T> where T : IComparable<T>
        {
            public Node<T> Root { get; set; }

            public Node<T> FindLowestCommonAncestor(T n1, T n2)
            { 
                Node<T> node = Root;

                while (node != null)
                {
                    int c1 = n1.CompareTo(node.Value);
                    int c2 = n2.CompareTo(node.Value);
 
                    if (c1 < 0 && c2 < 0) { node = node.Left; }  
                    else if (c1 > 0 && c2 > 0) { node = node.Right; }  
                    else { return node; }  
                }

                return null;
            }

            internal class Node<T>
            {
                public T Value { get; private set; }
                public Node<T> Left { get; set; }
                public Node<T> Right { get; set; }

                public Node(T value) { Value = value; }
            }
        }

} 
