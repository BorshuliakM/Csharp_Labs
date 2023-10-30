namespace Lab_5;

public interface IColoredShape : IShape
{
    string Color { get; set; }
    void PrintColor();
}



