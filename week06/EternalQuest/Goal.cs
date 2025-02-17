abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName() 
    { 
       return _shortName; 
    }

    public string GetDescription()
    {
       return _description;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} ({_points} points)";
    }
}