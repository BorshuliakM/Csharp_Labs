namespace Lab_7;

public class Teacher//клас викладача
{
    public string FullName { get; set; }//Повне ім'я
    public string Position { get; set; }//Посада
    private decimal salary;//Зп

    public Teacher(string FullName, string Position, decimal _salary)
    {
        this.FullName = FullName;
        this.Position = Position;
        Salary = _salary;
    }

    public decimal Salary//Властивість зп
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
    public virtual decimal CountSalary() => Salary;//підрахунок зп віртуальний
}
