using System;
using System.IO;

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
            int age = int.Parse(line);
                if (age >= 0 && age <= 2) { Console.WriteLine("Still in Mama's arms"); }
                else if (age >= 3 && age <= 4) { Console.WriteLine("Preschool Maniac"); }
                else if (age >= 5 && age <= 11) { Console.WriteLine("Elementary school"); }
                else if (age >= 12 && age <= 14) { Console.WriteLine("Middle school"); }
                else if (age >= 15 && age <= 18) { Console.WriteLine("High school"); }
                else if (age >= 19 && age <= 22) { Console.WriteLine("College"); }
                else if (age >= 23 && age <= 65) { Console.WriteLine("Working for the man"); }
                else if (age >= 66 && age <= 100) { Console.WriteLine("The Golden Years"); }
                else { Console.WriteLine("This program is for humans"); }
        }
    }
} 
