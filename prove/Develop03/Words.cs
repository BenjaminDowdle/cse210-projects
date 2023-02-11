using System.Text.RegularExpressions;
using System;

//Keeps track of a single word and whether it is shown or hidden.
public class Words
{
    public void HideWords(string[] scriptureArray, int i)
    {
        Reference reference = new Reference();
        string response = "";

        while (response.ToLower().Trim() != "quit" && !scriptureArray.All(word => word.StartsWith("_")))
        {
            Console.Clear();
            int attempts = 3;

            Console.WriteLine(reference.DisplaySelectedReference(i));

            foreach (string word in scriptureArray)
            {
                Console.Write($"{word} ");
            }

            while (attempts > 0 && !scriptureArray.All(word => word.StartsWith("_")))
            {
                Random r = new Random();
                int rInt = r.Next(0, scriptureArray.Length);
                foreach (string word in scriptureArray)
                {
                    if (word == scriptureArray[rInt] && !scriptureArray[rInt].StartsWith("_"))
                    {
                        scriptureArray[rInt] = Regex.Replace(scriptureArray[rInt], "[A-Za-z.,:;]", "_");
                        attempts -= 1;
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue. Type 'quit' to exit.");
            Console.WriteLine();
            response = Console.ReadLine();

        }

        Console.Clear();
        Console.WriteLine("GOOD JOB! Restart to study something else.");

    }

}

