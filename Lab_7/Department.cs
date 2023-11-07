namespace Lab_7;

public class Department//Клас факультету
{
    public string Department_Name { get; set; }//Ім'я факультету
    public List<Teacher> Teachers { get; set; }//Список викладачів
    private int number_Of_Teacher;//Кількість викладачів
    public Department(string Department_Name)
    {
        this.Department_Name = Department_Name;
        Teachers = new List<Teacher>();
    }
    public int NumberOf_Teacher() => Teachers.Count();//Метод для підряхунку кількості викладачів
}
