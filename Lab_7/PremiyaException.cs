namespace Lab_7;

public class PremiyaException : Exception
{
    public PremiyaException(int bonus) : base($"Неможливо створити співробітника - вказано негативний премію: {bonus}") { }
}
