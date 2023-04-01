public class Swimming : Activity
{
    private int _laps;

    public Swimming(double minutes, int laps) : base(minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        DateTime date = Date;
        string summary = $"{Date.ToShortDateString()} Swimming ({Minutes} min)- Distance: {Math.Round(GetDistance(), 1)}, Speed: {Math.Round(GetSpeed(), 1)} mph, Pace: {Math.Round(GetPace(), 1)} min per mile";

        return summary;
    }
}