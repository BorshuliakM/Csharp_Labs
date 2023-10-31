using Lab_6;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

CollectionType<Antelope> Antelops = new CollectionType<Antelope>();

Antelops.Add(new Antelope { Name = "Jeiran", Group = "Q", Residance = "1", Population = 1000 });
Antelops.Add(new Antelope { Name = "Gnu", Group = "W", Residance = "2", Population = 2500 });
Antelops.Add(new Antelope { Name = "Beiza", Group = "E", Residance = "3", Population = 30000 });
Antelops.Add(new Antelope { Name = "Art", Group = "R", Residance = "4", Population = 1000 });
Antelops.Add(new Antelope { Name = "Npf", Group = "T", Residance = "5", Population = 2500 });
Antelops.Add(new Antelope { Name = "Klm", Group = "Y", Residance = "6", Population = 30000 });

// Виведення елементів
for (int i = 0; i < Antelops.Count; i++)
{
    Console.WriteLine($"Назва = {Antelops[i].Name}\nГрупа = {Antelops[i].Group}\nЖитло = {Antelops[i].Residance}\nЧисельнысть популяції = {Antelops[i].Population}");
}

// Сортування за Population
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

var query3 = Antelops.Where(s => s.Population > 1000)
                    .OrderBy(s => s.Name)
                    .Select(s => new { s.Name, s.Population });

var query4 = Antelops.GroupBy(s => s.Population)
                    .Select(group => new { Age = group.Key, Count = group.Count() });

var query5 = Antelops.Where(s => s.Population > 2500)
                    .OrderByDescending(s => s.Population)
                    .Take(2)
                    .Select(s => new { s.Name, s.Population });

var query6 = Antelops.Where(s => s.Population < 20000)
                    .OrderBy(s => s.Population)
                    .Skip(1)
                    .Select(s => new { s.Name, s.Population });

var query7 = Antelops.OrderByDescending(s => s.Population)
                    .TakeWhile(s => s.Population > 20000)
                    .Select(s => new { s.Name, s.Population });

LinkedList<string> strings = new LinkedList<string>();
strings.AddLast("apple");
strings.AddLast("banana");
strings.AddLast("cherry");
strings.AddLast("date");
strings.AddLast("grape");

// Виведення рядків
Console.WriteLine("Strings:");
foreach (var str in strings)
{
    Console.WriteLine(str);
}

// Пошук рядків, що містять "a"
var containsA = strings.Where(s => s.Contains("a"));

Console.WriteLine("Strings containing 'a':");
foreach (var str in containsA)
{
    Console.WriteLine(str);
}

// Підрахунок кількості рядків довжини n
int n = 5;
var countN = strings.Count(s => s.Length == n);

Console.WriteLine($"Number of strings with length {n}: {countN}");

// Сортування у зростаючому порядку
var ascendingSort = strings.OrderBy(s => s);

Console.WriteLine("Ascending Sort:");
foreach (var str in ascendingSort)
{
    Console.WriteLine(str);
}

// Сортування у спадаючому порядку
var descendingSort = strings.OrderByDescending(s => s);

Console.WriteLine("Descending Sort:");
foreach (var str in descendingSort)
{
    Console.WriteLine(str);
}