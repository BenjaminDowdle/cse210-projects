public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, string type, Address address, string weather) : base(title, description, date, time, type, address)
    {
        _weather = weather;
    }

    public string Weather
    {
        get { return _weather; }
    }

    public void displayFullDetails()
    {
        Console.WriteLine("\n-----FULL DETAILS-----");
        displayStandardDetails();
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Weather: {Weather}");
        Console.WriteLine();
    }

}