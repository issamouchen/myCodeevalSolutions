using System;
using System.Linq;
using System.IO;
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
             var amplifiedLetters = GetAmplifiedLetters(line.ToCharArray()); 
             PrintAmplifiedLetters(amplifiedLetters);
        }
    }
    public static Dictionary<int, string[]> _amplifiedLettersDictionary = new Dictionary<int, string[]>()
	    {
	        {0, new[]{"-**--", "*--*-", "*--*-", "*--*-", "-**--", "-----"}},
            {1, new[]{"--*--", "-**--", "--*--", "--*--", "-***-", "-----"}},
            {2, new[]{"***--", "---*-", "-**--", "*----", "****-", "-----"}},
            {3, new[]{"***--", "---*-", "-**--", "---*-", "***--", "-----"}},
            {4, new[]{"-*---", "*--*-", "****-", "---*-", "---*-", "-----"}},
            {5, new[]{"****-", "*----", "***--", "---*-", "***--", "-----"}},
            {6, new[]{"-**--", "*----", "***--", "*--*-", "-**--", "-----"}},
            {7, new[]{"****-", "---*-", "--*--", "-*---", "-*---", "-----"}},  
            {8, new[]{"-**--", "*--*-", "-**--", "*--*-", "-**--", "-----"}},
            {9, new[]{"-**--", "*--*-", "-***-", "---*-", "-**--", "-----"}},
	    };
        private static void PrintAmplifiedLetters(List<string> amplifiedLetters)
	    {
            for (int i = 0; i < 6; i++)
	        {
                Console.WriteLine(amplifiedLetters[i]);
	        }
	    }

	    private static List<string> GetAmplifiedLetters(IEnumerable<char> toCharArray)
	    {
            List<string> amplifiedLetters = new List<string>();

	        foreach (var digit in toCharArray)
	        {
	            if (_amplifiedLettersDictionary.ContainsKey((int) Char.GetNumericValue(digit)))
	            {
	                if (amplifiedLetters.Any())
	                {
                        amplifiedLetters = MergeWithAmplifiedLetters(amplifiedLetters, _amplifiedLettersDictionary.FirstOrDefault(a => a.Key == (int)Char.GetNumericValue(digit)).Value);
	                }
	                else
	                {
                        amplifiedLetters.AddRange(_amplifiedLettersDictionary.FirstOrDefault(a => a.Key == (int)Char.GetNumericValue(digit)).Value);
	                }
	            }
	        }

	        return amplifiedLetters;
	    }

	    private static List<string> MergeWithAmplifiedLetters(List<string> amplifiedLetters, string[] amplifiedLetterToBeMerged)
	    {
            List<string> mergedAmplifiedLetters = new List<string>();

	        for (int i = 0; i < amplifiedLetters.Count(); i++)
	        {
                mergedAmplifiedLetters.Add(amplifiedLetters[i] + amplifiedLetterToBeMerged[i]);
	        }

	        return mergedAmplifiedLetters;
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
