namespace Lab_6;

public class Antelope : IComparable<Antelope>
{
    public string Name { get; set; } = "";
    public string Group { get; set; } = "";
    public string Residance { get; set; } = "";
    public int Population { get; set; } = 0;

    public Antelope() { }//Constructor without parametres
    public Antelope(string Name, string Group, string Residance, int Population)//Constructors with parametres
    {
        this.Name = Name;
        this.Group = Group;
        this.Residance = Residance;
        this.Population = Population;
    }
    public int CompareTo(Antelope other) => Population.CompareTo(other.Population);
    public void Print() => Console.WriteLine($"Назва = {Name}\nГрупа = {Group}\nЖитло = {Residance}\nЧисельнысть популяції = {Population}");//Print method
}
