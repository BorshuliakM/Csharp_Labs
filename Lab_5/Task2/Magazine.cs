using Lab_5.Task1;

namespace Lab_5.Task2;

public class Magazine : IPrintable
{
    private string name;
    public Magazine(string name)
    {
        this.name = name;
    }
    public void Print() => Console.WriteLine($"Magazine name = {name}");

    public static void printMagazines(IPrintable[] printable)
    {
        foreach (IPrintable p in printable)
        {
            if (p is Magazine)
            {
                p.Print();
            }
        }
    }
}
