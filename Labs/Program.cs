using Lab_2;
using System.Linq;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//1,1 
int[] ints = new int[] { 1, 5, 4, 2, 3, 8, 4, 2, 1, 5, 6, 8, 9, 77, 11, 22 };
ints.SortAsc();
foreach (int i in ints)
{
    Console.Write(i+"  ");
}
Antelope Jeiran = new("Джейран", "А", "Азія", 30000);
Antelope Gnu = new("Гну", "В", "Африка", 560000);
Antelope Beiza = new("Бейзя", "Н", "Африка", 2500);
Antelope Ump = new("Ump", "А", "Азія", 31000);
Antelope Uks = new("Uks", "В", "Африка", 570000);
Antelope Klm = new("Klm", "Н", "Африка", 2600);
Antelope Ktp = new("Ktp", "А", "Азія", 32000);
Antelope Kvb = new("Kvb", "В", "Африка", 580000);
Antelope Fgh = new("Fgh", "Н", "Африка", 2700);
Antelope Rty = new("Rty", "А", "Азія", 33000);
Antelope bbb = new();
//2.1
Console.WriteLine("\nКлькість антилоп = " + Antelope.GetCount());
//2.3
Antelops ant = new();
ant.Add_Antelope(Jeiran);
ant.Add_Antelope(Gnu);
ant.Add_Antelope(Beiza);
ant.Add_Antelope(Ump);
ant.Add_Antelope(Uks);
ant.Add_Antelope(Klm);
ant.Add_Antelope(Ktp);
ant.Add_Antelope(Kvb);
ant.Add_Antelope(Fgh);
ant.Add_Antelope(Rty);
//2.4-2.5
Console.WriteLine("\nВид з найменьшою популяцією");
Antelope zzz = ant.SpeciesPopulationMin();
zzz.Print();
IEnumerable<Antelope> k = ant.SpeciesPopulationLowerThan(5000);
Console.WriteLine("\nКількість антилоп меньше заданого числа:");
foreach (Antelope a in k)
{
    a.Print();
}
Console.WriteLine("\n");
ant.SpeciesCountLowerThan(12);

