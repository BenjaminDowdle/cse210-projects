public abstract class Activity
{
    private DateTime _date;
    private double _minutes;

    public Activity(double minutes)
    {
        _date = DateTime.Now;
        _minutes = minutes;
    }

    public DateTime Date
    {
        get { return _date; }
    }

    public double Minutes
    {
        get { return _minutes; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}