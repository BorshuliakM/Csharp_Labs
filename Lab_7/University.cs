namespace Lab_7;

public class University
{
    public string University_Name { get; set; }
    public List<Department> Deps { get; set; }
    public University(string University_Name)
    {
        this.University_Name = University_Name;
        Deps = new List<Department>();
    }
    public decimal CountSalary(decimal salary) => salary;
}