namespace Lab_5.Task1;

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
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
}
