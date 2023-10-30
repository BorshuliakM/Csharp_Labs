namespace Lab_5.Task3;

public enum ClothingSize
{
    XXS,
    XS,
    S,
    M,
    L
}
public class Shop
{
    public ClothingSize Size { get; set; }
    public int EuroSize { get; set; }
    public Shop(ClothingSize size, int euroSize)
    {
        Size = size;
        EuroSize = euroSize;
    }

    public string getDescription() => Size == ClothingSize.XXS ? "Children size" : "Adult size";
}
