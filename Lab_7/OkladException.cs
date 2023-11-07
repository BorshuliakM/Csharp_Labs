namespace Lab_7;

public class OkladException : Exception//Клас винятку окладу
{
    public OkladException(decimal oklad) : base($"Неможливо створити співробітника - вказано негативний оклад: {oklad}") { }
}
