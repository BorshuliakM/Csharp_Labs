namespace Lab_7;

public class Teacher
{
    public string FullName { get; set; }
    public string Position { get; set; }
    private decimal salary;

    public Teacher(string FullName, string Position, decimal _salary)
    {
        this.FullName = FullName;
        this.Position = Position;
        Salary = _salary;
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
            {
                throw new OkladException(value);
            }
            salary = value;
        }
    }
    public virtual decimal CountSalary() => Salary;
}
