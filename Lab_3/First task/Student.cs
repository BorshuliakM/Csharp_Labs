namespace Lab_3.First_Task;

public class Student : Person
{
    public int grade { get; set; }
    public Student(string FirstName, string LastName, int grade)
        : base(FirstName, LastName)
    {
        this.grade = grade;
    }
    public int SetAge(int age) => Age = age;
    public void ShowAge() => Console.WriteLine("Age " + Age);
    public void Study() => Console.WriteLine("I'm studying");
}
