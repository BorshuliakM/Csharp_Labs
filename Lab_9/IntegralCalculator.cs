namespace Lab_9;
public class IntegralCalculator
{
    public delegate double Function(double x);
    public double CalculateIntegral(Function func, double a, double b, int n)
    {
        double h = (b - a) / n;
        double result = 0.5 * (func(a) + func(b)); 

        for (int i = 1; i < n; i++)
        {
            double x = a + i * h;
            result += func(x);
        }

        return h * result;
    }
}