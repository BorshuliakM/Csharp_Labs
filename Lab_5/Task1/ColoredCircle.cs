namespace Lab_5.Task1;

public class ColoredCircle : IColoredShape//Кольоровий круг імплементує інтерфейс кольорової абстр форми
{
    public double Radius { get; set; }
    public string Color { get; set; }//Властивість кольору

    public ColoredCircle(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public void PrintShapeType()//Прінт форми
    {
        Console.WriteLine("Shape Type: Circle");
    }

    public void PrintArea()//Прінт площі
    {
        double area = Math.PI * Radius * Radius;
        Console.WriteLine($"Area: {area}");
    }

    public double FirstLinearDimension
    {
        get { return Radius; }
        set { Radius = value; }
    }

    public void PrintColor()//Прінт кольору
    {
        Console.WriteLine($"Color: {Color}");
    }
}
