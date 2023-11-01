namespace Lab_7;

public class Department
{
    public string Department_Name { get; set; }
    public List<Teacher> Teachers { get; set; }
    private int number_Of_Teacher;
    public Department(string Department_Name)
    {
        this.Department_Name = Department_Name;
        Teachers = new List<Teacher>();
    }
    public int NumberOf_Teacher() => Teachers.Count();
}
