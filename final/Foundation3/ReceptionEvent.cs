public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, string type, Address address, string email) : base(title, description, date, time, type, address)
    {
        _email = email;
    }

    public string Email
    {
        get { return _email; }
    }

    public void displayFullDetails()
    {
        Console.WriteLine("\n-----FULL DETAILS-----");
        displayStandardDetails();
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Please RSVP at: {Email}");
        Console.WriteLine();
    }

}