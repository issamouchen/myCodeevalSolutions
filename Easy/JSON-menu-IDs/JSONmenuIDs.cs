 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            	 var jsonData = line.Replace("\"", "").Replace("\\", "").Split('[');
						Console.WriteLine(GetLabeledSums(jsonData[1].Split(' ')));
        }
    }
    
    private static int GetLabeledSums(string[] jsonDataCollection)
		{
			Stack<string> sumValidationStack = new Stack<string>();
			var finalSumOfIds = 0;
			var isLabeled = false;

			for (int i=0; i<jsonDataCollection.Count(); i++)
			{
				if (jsonDataCollection[i].Contains("{"))
				{
					sumValidationStack.Push(jsonDataCollection[i + 1]);
				}
				else if (jsonDataCollection[i].Contains("label"))
				{
					isLabeled = true;
				}
				else if (jsonDataCollection[i].Contains("}"))
				{
					if (isLabeled)
					{
						var idValue = sumValidationStack.Peek();
						finalSumOfIds = finalSumOfIds + Convert.ToInt32(idValue.Replace(",", ""));
					}

					isLabeled = false;
				}
			}

			return Convert.ToInt32(finalSumOfIds);
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
