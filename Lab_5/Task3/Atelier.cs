namespace Lab_5.Task3;

public class Atelier
{
    public void DressWoman(FemaleClothing[] clothes)
    {
        Console.WriteLine("Dressing Woman:");
        foreach (var item in clothes)
        {
            item.DressWoman();
        }
    }

    public void DressMan(MaleClothing[] clothes)
    {
        Console.WriteLine("Dressing Man:");
        foreach (var item in clothes)
        {
            item.DressMan();
        }
    }
}
