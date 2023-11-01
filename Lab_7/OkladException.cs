namespace Lab_7;

public class OkladException : Exception
{
    public OkladException(decimal oklad) : base($"Неможливо створити співробітника - вказано негативний оклад: {oklad}") { }
}
