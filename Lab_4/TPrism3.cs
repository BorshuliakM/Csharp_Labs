namespace Lab_4;

public class TPrism3 : TPrism
{
    public TPrism3(double length, double width, double height) : base(length, width, height)
    {
    }

    public override double GetVolume()
    {
        // For a triangular prism, use the formula: (base * height * width) / 2
        return (length * width * height) / 2;
    }

    public override double GetSurfaceArea()
    {
        // For a triangular prism, use the formula for surface area
        // Since it's not specified in the question, you should implement this formula.
        // Here's an example assuming it's an equilateral triangular prism:
        return 3 * length * height;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Triangular Prism");
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Volume: {GetVolume()}");
        Console.WriteLine($"Surface Area: {GetSurfaceArea()}");
    }
}
