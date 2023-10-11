namespace Lab_2;

public class Antelops//2,2 Класс списку видів антилоп
{
    private List<Antelope> antelops;//Створюємо ліст антилоп
    public Antelops()
    {
        antelops = new List<Antelope>(); //Ініціалізовуємо його
    }

    //Пишемо декілька методів для додавання і видалення видів антилоп в список
    public void Add_Antelope(Antelope antelop) => antelops.Add(antelop);
    public void Remove_Antelope(Antelope antelop) => antelops.Remove(antelop);
    //2,4 Метод для визначення видів у яких популяція меньше заданого числа 
    public IEnumerable<Antelope> SpeciesPopulationLowerThan(int x) => antelops.Where(z => z.population < x);
    //2,4 Найменьша популяція
    public Antelope? SpeciesPopulationMin() => antelops.MinBy(x => x.population);
    //2,5 Кількість видів меньших за значення
    public void SpeciesCountLowerThan(int x)
    {
        if (antelops.Count() > x) Console.WriteLine("Антилоп більше заданого значення");
        else Console.WriteLine("Антилоп Меньше або рівно заданому значенню");
    }
}
