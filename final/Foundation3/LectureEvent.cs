public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, string type, Address address, string speaker, int capacity) : base(title, description, date, time, type, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string Speaker
    {
        get { return _speaker; }
    }

    public int Capacity
    {
        get { return _capacity; }
    }

    public void displayFullDetails()
    {
        Console.WriteLine("\n-----FULL DETAILS-----");
        displayStandardDetails();
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Speaker: {Speaker}");
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine();
    }
}