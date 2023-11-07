namespace Lab_7;

public class University//Клас університету
{
    public string University_Name { get; set; }//Ім'я університету
    public List<Department> Deps { get; set; }//Список факультетів
    public University(string University_Name)
    {
        this.University_Name = University_Name;
        Deps = new List<Department>();
    }
    public decimal CountSalary(decimal salary) => salary;//Метод підрахунку зп
}