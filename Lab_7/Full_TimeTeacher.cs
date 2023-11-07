namespace Lab_7;

public class Full_TimeTeacher : Teacher//Викладач 
{
    public int Bonus { get; set; }//Премія
    public Full_TimeTeacher(string FullName, string Position, decimal salary, int Bonus) : base(FullName, Position, salary)
    {
        this.Bonus = Bonus;
    }
    public override decimal CountSalary()
    {
        if (Bonus < 0) throw new PremiyaException(Bonus);
        return Salary += (Bonus * Salary) / 100;
    }
}
