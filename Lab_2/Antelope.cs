using System.Text.RegularExpressions;

namespace Lab_2;

public class Antelope//Class describes Antelopas species
{
    private static int object_Count;//task 2_1

    //Auto props with default values
    public string name { get; set; } = "";
    public string group { get; set; } = "";
    public string residance { get; set; } = "";
    public int population { get; set; } = 0;

    public Antelope()//Constructor without parametres
    {
        object_Count++;
    }

    public Antelope(string name, string group, string residance, int population)//Constructors with parametres
    {
        this.name = name;
        this.group = group;
        this.residance = residance;
        this.population = population;
        object_Count++;
    }

    public static int GetCount() => object_Count;
    public void Print() => Console.WriteLine($"Назва = {name}\nГрупа = {group}\nЖитло = {residance}\nЧисельнысть популяції = {population}");//Print method

}

