
using System;
using System.Collections.Generic;
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
            Console.WriteLine(MorseCommunicator.Decode(line));
        }
    }
     static class MorseCommunicator
        {
            static readonly Dictionary<char, string> asciToMorse = new Dictionary<char, string>
            {
                {'A', ".-"},    {'B', "-..."},  {'C', "-.-."},  {'D', "-.."}, 
                {'E', "."},     {'F', "..-."},  {'G', "--."},   {'H', "...."},
                {'I', ".."},    {'J', ".---"},  {'K', "-.-"},   {'L', ".-.."},
                {'M', "--"},    {'N', "-."},    {'O', "---"},   {'P', ".--."}, 
                {'Q', "--.-"},  {'R', ".-."},   {'S', "..."},   {'T', "-"}, 
                {'U', "..-"},   {'V', "...-"},  {'W', ".--"},   {'X', "-..-"}, 
                {'Y', "-.--"},  {'Z', "--.."},  {'0', "-----"}, {'1', ".----"}, 
                {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."}, 
                {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."}    
            };

            static readonly Dictionary<string, char> morseToAsci = new Dictionary<string, char>
            {
                {".-", 'A'},    {"-...", 'B'},  {"-.-.", 'C'},  {"-..", 'D'}, 
                {".", 'E'},     {"..-.", 'F'},  {"--.", 'G'},   {"....", 'H'},
                {"..", 'I'},    {".---", 'J'},  {"-.-", 'K'},   {".-..", 'L'},
                {"--", 'M'},    {"-.", 'N'},    {"---", 'O'},   {".--.", 'P'}, 
                {"--.-", 'Q'},  {".-.", 'R'},   {"...", 'S'},   {"-", 'T'}, 
                {"..-",'U'},    {"...-", 'V'},  {".--", 'W'},   {"-..-", 'X'}, 
                {"-.--", 'Y'},  {"--..", 'Z'},  {"-----", '0'}, {".----", '1'}, 
                {"..---", '2'}, {"...--", '3'}, {"....-", '4'}, {".....", '5'}, 
                {"-....", '6'}, {"--...", '7'}, {"---..", '8'}, {"----.", '9'}    
            };

            public static string Encode(string text)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var c in text)
                {
                    sb.AppendFormat("{0} ", asciToMorse.ContainsKey(c) ? asciToMorse[c] : " ");
                }

                return sb.ToString().Trim();
            }

            public static string Decode(string morse)
            {
                string[] split = morse.Split(' ');
                StringBuilder sb = new StringBuilder();
                foreach (var s in split)
                {
                    sb.Append(morseToAsci.ContainsKey(s) ? morseToAsci[s] : ' ');
                }

                return sb.ToString();
            }
        }
} 
