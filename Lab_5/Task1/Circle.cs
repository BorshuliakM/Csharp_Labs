namespace Lab_5.Task1;

public class Circle : IShape//Клас кругу, реалізує інтерфейс форми абстр
{
    public double Radius { get; set; }//Властивість радіус

    public Circle(double radius)//Конструктор кругу
    {
        Radius = radius;
    }

    public void PrintShapeType()//Вивід форми
    {
        Console.WriteLine("Shape Type: Circle");
    }

    public void PrintArea()//Вивід площі на консоль
    {
        double area = Math.PI * Radius * Radius;
        Console.WriteLine($"Area: {area}");
    }

    public double FirstLinearDimension//Повертає радіус
    {
        get { return Radius; }
        set { Radius = value; }
    }
}
