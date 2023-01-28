using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journal 2.0!");

        //Creating myJournal
        Journal myJournal = new Journal();

        //Menu 
        string menuChoice = "-1";

        while (menuChoice != "5")
        {
            Console.WriteLine("Please select one of the options (1-5):");
            Console.WriteLine("  1. Write");
            Console.WriteLine("  2. Display");
            Console.WriteLine("  3. Load");
            Console.WriteLine("  4. Save");
            Console.WriteLine("  5. Quit");
            menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                //Generate and display prompt
                Prompt prompt1 = new Prompt();
                string prompt = prompt1.DisplayPrompt();
                Console.WriteLine(prompt);

                //Write an entry and save it to myJournal._entries
                Entry entry1 = new Entry();
                entry1._entry = Console.ReadLine();
                entry1._date = DateTime.Now.ToString();
                entry1._prompt = prompt;

                myJournal._entries.Add(entry1._date);
                myJournal._entries.Add(entry1._prompt);
                myJournal._entries.Add(entry1._entry);
            }

            if (menuChoice == "2")
            {
                myJournal.DisplayJournal();
            }

            if (menuChoice == "3")
            {
                myJournal.LoadJournal();
                Console.WriteLine("Your journal has been loaded.");
            }

            if (menuChoice == "4")
            {
                myJournal.SaveJournal();
                Console.WriteLine("Your journal was saved.");
            }

        }
    }
}