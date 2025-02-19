public class Swimming : Activity
{
    private int _laps; 

    public Swimming(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000 * 0.62; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60; 
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance(); 
    }
}