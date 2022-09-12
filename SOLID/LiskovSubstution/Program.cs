// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var square = new Square { Width = 5 };
var rectangle = new Rectangle { Width = 4, Height = 10 };
Console.WriteLine($"square area: {square.GetArea()}; rectangle area : {rectangle.GetArea()}");


var newReactangle = Create(4);

Console.WriteLine(newReactangle.GetArea());


IAreaCalcutable Create(int width, int? height = null)
{    //bir biçimde...
    if (height.HasValue)
    {
        return new Rectangle { Height = height.Value, Width = width };
    }
    return new Square { Width = width };

}

public interface IAreaCalcutable
{
    int GetArea();
}
public class Rectangle : IAreaCalcutable
{
    protected int width;
    protected int height;
    public virtual int Width { get => width; set { width = value; } }
    public virtual int Height { get => height; set { height = value; } }

    public int GetArea()
    {
        return Width * Height;
    }
}

public class Square : IAreaCalcutable //: Rectangle
{
    public int Width { get; set; }
    public int GetArea()
    {
        return Width * Width;
    }

}