public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            string goalString = $"[X] {_shortName} ({_description})";
            return goalString;
        }
        else
        {
            string goalString = $"[ ] {_shortName} ({_description})";
            return goalString;
        }
    }

    public abstract string GetStringRepresentation();
}