using System;

class Program
{
    static void Main(string[] args)
    {

        string choice = "";

        Console.Clear();
        Console.WriteLine("Hello! Welcome to MindFull.");

        // --------------------Menu-----------------------

        while (choice != "4")
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Please make a selection (1-4): ");

            choice = Console.ReadLine();
            int activityInt = Int32.Parse(choice);

            // --------------Breathing Activity----------------
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();

                breathingActivity.ActivityName = "Breathing Activity";
                breathingActivity.displayWelcomeMessage();
                breathingActivity.displayDescription(activityInt);

                breathingActivity.Time = Int32.Parse(Console.ReadLine());

                breathingActivity.GetReady();
                breathingActivity.displayBreathing(breathingActivity.Time);
            }

            // --------------Reflecting Activity----------------
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();

                reflectingActivity.ActivityName = "Reflecting Activity";
                reflectingActivity.displayWelcomeMessage();
                reflectingActivity.displayDescription(activityInt);

                reflectingActivity.Time = Int32.Parse(Console.ReadLine());

                reflectingActivity.GetReady();
                reflectingActivity.displayReflection(reflectingActivity.Time);
            }

            // --------------Listing Activity----------------
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();

                listingActivity.ActivityName = "Listing Activity";
                listingActivity.displayWelcomeMessage();
                listingActivity.displayDescription(activityInt);

                listingActivity.Time = Int32.Parse(Console.ReadLine());

                listingActivity.GetReady();
                listingActivity.displayListing(listingActivity.Time);
            }
        }


        // --------------Goodbye----------------
        Console.Clear();
        Console.WriteLine("Thanks for using the app. Goodbye.");

    }
}