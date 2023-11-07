namespace Lab_7;

public class PremiyaException : Exception//Клас винятку премії
{
    public PremiyaException(int bonus) : base($"Неможливо створити співробітника - вказано негативний премію: {bonus}") { }
}
