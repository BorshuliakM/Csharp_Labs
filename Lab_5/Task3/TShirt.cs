namespace Lab_5.Task3;

public class TShirt : Clothing, MaleClothing, FemaleClothing
{
    public TShirt(ClothingSize size, decimal cost, string color) : base(size, cost, color)
    {
    }

    public void DressMan()
    {
        Console.WriteLine($"Men's T-Shirt - Size: {Size}, Color: {Color}, Cost: {Cost}");
    }

    public void DressWoman()
    {
        Console.WriteLine($"Women's T-Shirt - Size: {Size}, Color: {Color}, Cost: {Cost}");
    }
}
