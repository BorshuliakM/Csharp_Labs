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
Lab_3.Second_Task.Worker Ivan = new("Ivan", 25, 1000);
Lab_3.Second_Task.Worker Vasya = new("Vasya", 26, 2000);
Console.WriteLine("Sum salary = "+Ivan.Salary + Vasya.Salary);