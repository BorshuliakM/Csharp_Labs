namespace Lab_3.Third_Task;

public class Child : Parent
{
    public List<string> Friends;
    public int PhoneNumber;
    public string Birthday;

    public Child(string Name, int Age, int Day, int Month, int Year, int PhoneNumber, List<string> Friends) : base(Name, Age, Day, Month, Year) 
    {
        this.Name = Name;
        this.Age = Age;
        this.Day = Day;
        this.Month = Month;
        this.Year = Year;
        this.PhoneNumber = PhoneNumber;
        this.Friends = Friends;
        Birthday = $"{Day} {Month} {Year}";
    }
    public new void Print() => Console.WriteLine($"Name = {Name} Age = {Age} Birthday = {Birthday}");
}
