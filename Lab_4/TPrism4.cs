namespace Lab_4;

public class TPrism4 : TPrism
{
    public TPrism4(double length, double width, double height) : base(length, width, height)
    {
    }

    public override double GetSurfaceArea()
    {
        // For a quadrilateral prism, use the formula: 2 * (length * width + length * height + width * height)
        return 2 * (length * width + length * height + width * height);
    }

    public override double GetVolume()
    {
        // For a quadrilateral prism, use the formula: base * height * width
        return length * width * height;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Quadrilateral Prism");
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Volume: {GetVolume()}");
        Console.WriteLine($"Surface Area: {GetSurfaceArea()}");
    }
}
