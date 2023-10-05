using System.Text.RegularExpressions;

namespace Lab_1;

public class Antelope//Class describes Antelopas species
{
    //Auto props with default values
    public string name { get; set; } = "";
    public string group { get; set; } = "";
    public string residance { get; set; } = "";
    public int population { get; set; } = 0;

    public Antelope() { }//Constructor without parametres
    public Antelope(string name, string group, string residance, int population)//Constructors with parametres
    {
        this.name = name;
        this.group = group;
        this.residance = residance;
        this.population = population;
    }

    public void Print() => Console.WriteLine($"Назва = {name}\nГрупа = {group}\nЖитло = {residance}\nЧисельнысть популяції = {population}");//Print method

}

