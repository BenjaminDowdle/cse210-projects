using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        Words words = new Words();


        Console.WriteLine("Welcome to Scripture Study+");
        Console.WriteLine();
        Console.WriteLine("Please select a scripture (1-5): ");

        reference.DisplayAllReferences();
        string choiceScripture = Console.ReadLine();
        int i = Int32.Parse(choiceScripture);

        Console.Clear();
        Console.WriteLine(reference.DisplaySelectedReference(i));
        words.HideWords(scripture.GetScriptureArray(i), i);

        Console.WriteLine();
        Console.WriteLine("Thanks for Studying! Goodbye!");
    }
}