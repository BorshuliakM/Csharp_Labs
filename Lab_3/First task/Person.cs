namespace Lab_3.First_Task;

public class Person //Клас персон
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string FirstName, string LastName) 
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
    public Person(string FirstName, string LastName, int Age) 
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Age = Age;
    }
    public void Greet() => Console.WriteLine($"Hi i'm {FirstName} {LastName} Age {Age}");
}
