namespace Lab_5.Task1;

public interface IColoredShape : IShape
{
    string Color { get; set; }
    void PrintColor();
}



