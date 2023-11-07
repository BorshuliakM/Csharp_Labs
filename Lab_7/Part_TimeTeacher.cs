namespace Lab_7;

public class Part_TimeTeacher : Teacher//Викладач сумісник
{
    public Part_TimeTeacher(string FullName, string Position, decimal salary) : base(FullName, Position, salary) { }
    public override decimal CountSalary() => Salary;
}
