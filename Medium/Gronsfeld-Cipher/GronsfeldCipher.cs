using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
              Cipher c = new Cipher();
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
            var split = line.Split(';');

                var key = new byte[split[0].Length];
                for (int i = 0; i < key.Length; i++) { key[i] = (byte)(split[0][i] - '0'); }

                Console.WriteLine(c.Decode(split[1], key));
        }
    }
        class Cipher
        {
            string alphabet = " !\"#$%&'()*+,-./0123456789:<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> map;

            public Cipher() { this.map = GenerateAlphabetMapping(alphabet); }
            public Cipher(string alphabet)
            {
                this.alphabet = alphabet;
                this.map = GenerateAlphabetMapping(alphabet);
            }
             
            private Dictionary<char, int> GenerateAlphabetMapping(string alphabet)
            {
                var map = new Dictionary<char, int>(alphabet.Length);
                for (int i = 0; i < alphabet.Length; i++)
                {
                    map.Add(alphabet[i], i);
                }

                return map;
            }

            public char[] Encode(string msg, byte[] key)
            {
                char[] enc = new char[msg.Length];

                for (int i = 0; i < msg.Length; i++)
                {
                    enc[i] = Shift(msg[i], key[i % key.Length], false);
                }

                return enc;
            }

            public char[] Decode(string msg, byte[] key)
            {
                char[] dec = new char[msg.Length];

                for (int i = 0; i < msg.Length; i++)
                {
                    dec[i] = Shift(msg[i], key[i % key.Length], true);
                }

                return dec;
            }

            private char Shift(char c, int rot, bool reverse)
            {
                int index = map[c];
                int newIndex = reverse ? index - rot : index + rot;
                 
                if (newIndex < 0) { newIndex += alphabet.Length; }
                else if (newIndex >= alphabet.Length) { newIndex -= alphabet.Length; }
                return alphabet[newIndex];
            }

        }
} 
