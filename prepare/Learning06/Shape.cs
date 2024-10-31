public class Shape
{
    protected string _color = "White";


    public Shape(string color)
    {
        _color = color;
    }
    public string getColor()
    {
        return _color;
    }

    public void setColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        double area = 0;
        return area;
    }
}