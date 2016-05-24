using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            Console.WriteLine(GetStringBeauty((line.ToLower()).ToCharArray()));
        }
    }
private static string GetStringBeauty(char[] characterCollection)
		{
			int beautifulStringValue = 0;
            int beautyValue = 26;

			Dictionary<char, int> characterOccurance = new Dictionary<char, int>();

			foreach (var character in characterCollection)
			{
				if (character != ' ' && Char.IsLetter(character))
				{
					if (!characterOccurance.ContainsKey(character))
					{
						characterOccurance.Add(character, characterCollection.Count(a => a == character));
					}
				}
			}

			IOrderedEnumerable<KeyValuePair<char, int>> orderedCharacterOccurance = characterOccurance.OrderByDescending(a => a.Value);

			foreach (var orderedCharacter in orderedCharacterOccurance)
			{
				beautifulStringValue = beautifulStringValue + (beautyValue * orderedCharacter.Value);

				beautyValue = beautyValue - 1;
			}

			return beautifulStringValue.ToString();
		}

		static IEnumerable<string> ReadFile(string filePath)
		{
			string[] fileLines = { };

			try
			{
				fileLines = File.ReadAllLines(filePath);
			}
			catch (Exception e)
			{
				throw e.InnerException;
			}

			return fileLines.ToList();
		}
} 
