using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Event Organizer\n");

        Address address1 = new Address("244 Lecture Lane", "Spokane", "Washington");
        LectureEvent lectureEvent = new LectureEvent("The Power of Thinking", "This lecture will open your mind to new possibilities", "April 24th, 2023", "7:00 PM", "Lecture", address1, "Tom Thorton", 1200);

        Address address2 = new Address("1528 Reception Road", "Idaho Falls", "Idaho");
        ReceptionEvent receptionEvent = new ReceptionEvent("Reception of Liz and Lucas", "Come join to celebrate the new bride and groom", "April 16th, 2023", "6:00 PM", "Reception", address2, "lizandlucas@giveusgifts.com");

        Address address3 = new Address("100 Outdoor Way", "El Paso", "Texas");
        OutdoorEvent outdoorEvent = new OutdoorEvent("Charlie's 1st Birthday Party", "Come celebrate with the big 1 year old.", "April 8th, 2023", "2:00 PM", "Outdoor", address3, "Cloudy - 62 F");

        Console.WriteLine("-----STANDARD DETAILS-----");
        lectureEvent.displayStandardDetails();
        lectureEvent.displayFullDetails();
        lectureEvent.displayShortDescription();
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("-----STANDARD DETAILS-----");
        receptionEvent.displayStandardDetails();
        receptionEvent.displayFullDetails();
        receptionEvent.displayShortDescription();
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("-----STANDARD DETAILS-----");
        outdoorEvent.displayStandardDetails();
        outdoorEvent.displayFullDetails();
        outdoorEvent.displayShortDescription();
        Console.WriteLine("--------------------------------------------------");

    }
}