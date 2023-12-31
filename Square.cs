namespace Homework_14;

public class Square : Rectangle
{
    public Square()
    {

    }

    public Square(double side) : base(side, side)
    {
        side = GetWidth();
    }
    public Square(double side, string color, bool filled) : base(side, side, color, filled)
    {
        side = GetWidth();
    }
    public double GetSide()
    {
        return GetWidth();
    }
    public void SetSide(double side)
    {
        side = GetSide();
    }
    public override void SetWidth(double _width)
    {
        base.SetWidth(_width);
    }
    public override void SetLenght(double _lenght)
    {
        base.SetLenght(_lenght);
    }

    public override string ToString()
    {
        return $"Square[Rectangle[{base.ToString()}]]  ";
    }



}
