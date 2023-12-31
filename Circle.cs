namespace Homework_14;

public class Circle : Shape
{
    protected double radius = 3.5;

    public Circle()
    {

    }
    public Circle(double _radius)
    {
        radius = _radius;
    }
    public Circle(double _radius, string _color, bool _filled) : base(_color, _filled)
    {
        radius = _radius;
    }

    public double GetRadius()
    {
        return radius;
    }
    public void SetRadius(double _radius)
    {
        radius = _radius;
    }
    public override double GetArea()
    {
        return radius * radius * 3.14;
    }
    public override double GetPerimetr()
    {
        return radius * 2 * 3.14;
    }

    public override string ToString()
    {
        return $"Circle[ {base.ToString()}], radius = {radius} ]  ";
    }


}
