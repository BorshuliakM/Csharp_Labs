using Lab_6;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

CollectionType<Antelope> Antelops = new CollectionType<Antelope>();

Antelops.Add(new Antelope { Name = "Jeiran", Group = "Q", Residance = "1", Population = 1000 });
Antelops.Add(new Antelope { Name = "Gnu", Group = "W", Residance = "2", Population = 2500 });
Antelops.Add(new Antelope { Name = "Beiza", Group = "E", Residance = "3", Population = 30000 });

// Виведення елементів
for (int i = 0; i < Antelops.Count; i++)
{
    Console.WriteLine($"Назва = {Antelops[i].Name}\nГрупа = {Antelops[i].Group}\nЖитло = {Antelops[i].Residance}\nЧисельнысть популяції = {Antelops[i].Population}");
}

// Сортування за віком
Antelops.Sort();

// LINQ-запити
var query1 = Antelops.Where(s => s.Population > 1000).OrderBy(s => s.Group);
var query2 = Antelops.GroupBy(s => s.Population);


foreach (var antelope in query1)
{
    Console.WriteLine($"Name: {antelope.Name}, Age: {antelope.Population}");
}

foreach (var group in query2)
{
    Console.WriteLine($"Antelops with population {group.Key}: {group.Count()}");
}