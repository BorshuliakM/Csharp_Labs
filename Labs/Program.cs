using Lab_1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Creating objects
Antelope Jeiran = new ("Джейран", "А", "Азія", 30000);
Antelope Gnu = new ("Гну", "В", "Африка", 560000);
Antelope Beiza = new ("Бейзя", "Н", "Африка", 2500);
Antelope Antelope = new(); 

Jeiran.Print();
Gnu.Print(); 
Beiza.Print();
Antelope.Print();