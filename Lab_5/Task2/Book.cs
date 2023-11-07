using Lab_5.Task1;

namespace Lab_5.Task2;

public class Book : IPrintable//Клас книги реалізує інтерфейс прінт
{
    private string name;//Ім'я книги 
    public Book(string name)
    {
        this.name = name;
    }

    public void Print() => Console.WriteLine($"Book name = {name}");//Прінт

    public static void printBooks(IPrintable[] printable)//Статичний петод прінту книги
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
