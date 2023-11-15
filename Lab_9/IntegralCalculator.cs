namespace Lab_9;


public class IntegralCalculator
{
    //task1 deleagte 1 parameter
    public delegate double Func(double x);

    public double CalculateIntegral(Func func, double a, double b, int n)
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