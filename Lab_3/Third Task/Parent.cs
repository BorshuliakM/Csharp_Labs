namespace Lab_3.Third_Task;

public class Parent
{
    public string? Name;
    public int Age;
    public int Day;
    public int Month;
    public int Year;
    public Parent(string Name, int Age, int Day, int Month, int Year)
    {
        this.Name = Name;
        this.Age = Age;
        this.Day = Day;
        this.Month = Month;
        this.Year = Year;
    }
    public void IsItIntercalary()
    {
        if (Year % 4 == 0) Console.WriteLine("Is it intercalary");
        else Console.WriteLine("Is it not intercalary");
    }
    public void YearIncreaseBy5()
    {
        Age += 5;
        Console.WriteLine("Year increased " + (Year += 5));
    }
    public void DaysToBirthday()
    {
        DateTime date = new DateTime(Year, Month, Day);
        DateTime currentDate = DateTime.Now;
        DateTime nextBthday = new DateTime(currentDate.Year, date.Month, date.Day);
        if (currentDate > nextBthday)
        {
            nextBthday = nextBthday.AddYears(1);
        }
        TimeSpan daysUntilBthday = nextBthday - currentDate;
        Console.WriteLine("Days to birthday " + daysUntilBthday.Days);
    }
    public void Print() => Console.WriteLine($"Name = {Name} Age = {Age} Birthday = {Day} {Month} {Year}");
}
