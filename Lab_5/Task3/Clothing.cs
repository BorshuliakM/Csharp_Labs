namespace Lab_5.Task3;

public abstract class Clothing
{
    public ClothingSize Size { get; set; }
    public decimal Cost { get; set; }
    public string Color { get; set; }

    public Clothing(ClothingSize size, decimal cost, string color)
    {
        Size = size;
        Cost = cost;
        Color = color;
    }
}
