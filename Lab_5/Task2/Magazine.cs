using Lab_5.Task1;

namespace Lab_5.Task2;

public class Magazine : IPrintable//Клас журналу
{
    private string name;//Ім'я
    public Magazine(string name)
    {
        this.name = name;
    }
    public void Print() => Console.WriteLine($"Magazine name = {name}");//Прінт

    public static void printMagazines(IPrintable[] printable)//Прінт журналів статичний метод
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
