namespace Homework_14;

public class Rectangle : Shape
{

    protected double width = 1.0;
    protected double lenght = 1.0;

    public Rectangle()
    {

    }
    public Rectangle(double _width, double _lenght)
    {
        width = _width;
        lenght = _lenght;
    }
    public Rectangle(double _width, double _lenght, string _color, bool _filled) : base(_color, _filled)
    {
        width = _width;
        lenght = _lenght;
    }
    public double GetWidth()
    {
        return width;
    }
    public virtual void SetWidth(double _width)
    {
        width = _width;
    }
    public double GetLenght()
    {
        return lenght;
    }
    public virtual void SetLenght(double _lenght)
    {
        lenght = _lenght;
    }

    public override double GetArea()
    {
        return width * lenght;
    }
    public override double GetPerimetr()
    {
        return 2 * (width * lenght);
    }

    public override string ToString()
    {
        return $"Rectangle[ {base.ToString()}], width = {width}, lenght = {lenght} ]  ";
    }

}
