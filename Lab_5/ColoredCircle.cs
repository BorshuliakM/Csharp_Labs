namespace Lab_5;

public class ColoredCircle : IColoredShape
{
    public double Radius { get; set; }
    public string Color { get; set; }

    public ColoredCircle(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public void PrintShapeType()
    {
        Console.WriteLine("Shape Type: Circle");
    }

    public void PrintArea()
    {
        double area = Math.PI * Radius * Radius;
        Console.WriteLine($"Area: {area}");
    }

    public double FirstLinearDimension
    {
        get { return Radius; }
        set { Radius = value; }
    }

    public void PrintColor()
    {
        Console.WriteLine($"Color: {Color}");
    }
}
