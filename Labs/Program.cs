using Lab_3;

//First Task
Lab_3.First_Task.Person Bob = new("Bob", "Lancer", 21);
Bob.Greet();

Lab_3.First_Task.Student Dima = new("Dima", "Kerpov", 1);
Dima.SetAge(19);
Dima.Greet();
Dima.ShowAge();

Lab_3.First_Task.Professor Oleh = new("Oleh", "Somer", 42, "Math");
Oleh.Explain();

//Second Task
Console.WriteLine();
Lab_3.Second_Task.Worker Ivan = new("Ivan", 25, 1000);
Lab_3.Second_Task.Worker Vasya = new("Vasya", 26, 2000);
Ivan.Print();
Vasya.Print();
Console.WriteLine("Sum salary = " + (Ivan.Salary + Vasya.Salary));

//Third Task
Console.WriteLine();
List<string> friends = new List<string>() { "Serhii", "Max" };
Lab_3.Third_Task.Parent Dmytro = new("Dmytro", 40, 19, 12, 1982);
Lab_3.Third_Task.Child Denis = new("Ivan", 20, 17, 11, 2002, 0976587142, friends);

Dmytro.Print();
Denis.Print();
Dmytro.DaysToBirthday();
Dmytro.IsItIntercalary();
Dmytro.YearIncreaseBy5();
Dmytro.Print();
