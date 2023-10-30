using Lab_5;

IShape[] shapes = new IShape[]
{
    new Circle(5.0),
    new Circle(3.0),
    new Circle(2.0),
    new ColoredCircle(4.0, "Red"),
    new ColoredCircle(6.0, "Blue"),
    new ColoredCircle(2.5, "Green")
};

foreach (IShape shape in shapes)
{
    shape.PrintShapeType();
    shape.PrintArea();
    Console.WriteLine($"First Linear Dimension: {shape.FirstLinearDimension}");

    if (shape is IColoredShape coloredShape)
    {
        coloredShape.PrintColor();
    }

    Console.WriteLine();
}
