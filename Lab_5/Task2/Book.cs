using Lab_5.Task1;

namespace Lab_5.Task2;

public class Book : IPrintable
{
    private string name;
    public Book(string name)
    {
        this.name = name;
    }

    public void Print() => Console.WriteLine($"Book name = {name}");

    public static void printBooks(IPrintable[] printable)
    {
        foreach (IPrintable p in printable)
        {
            if (p is Book)
            {
                p.Print();
            }
        }
    }
}
