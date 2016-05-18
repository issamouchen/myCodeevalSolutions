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
             Console.WriteLine(CapitalizeAllWords(line));
        }
    }
    static string CapitalizeAllWords(string sentence)
        {
            var words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder(sentence);
            bool newWord = true;

            for (int i = 0; i < sb.Length; i++)
            { 
                char c = sb[i];
                if (newWord && c >= 'a' && c <= 'z')
                {
                    sb[i] = (char)(c & (255 - 32)); ;
                    newWord = false;
                }
                else if (c == ' ') { newWord = true; }
                else { newWord = false; }
            }

            return sb.ToString();
        }
} 
