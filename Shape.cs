namespace Homework_14;

public abstract class Shape
{
    protected string color = "green";
    protected bool filled = true;

    public Shape() { }

    public Shape(string _color, bool _filled)
    {
        color = _color;
        filled = _filled;
    }

    public string GetColor()
    {
        return color;
    }
    public void SetColor(string _color)
    {
        color = _color;
    }
    public bool IsFilled()
    {
        return filled;
    }
    public void SetFilled(bool _filled)
    {
        filled = _filled;
    }

    public abstract double GetArea();
    public abstract double GetPerimetr();

    public override string ToString()
    {
        return $"Shape[color = {color}, filled = {filled}]";
    }

}
