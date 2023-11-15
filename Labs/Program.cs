using Lab_9;

//task 1
IntegralCalculator integralCalculator = new IntegralCalculator();

IntegralCalculator.Func func = x => x * x;

double a = 0; // Початкова точка інтервалу
double b = 1; // Кінцева точка інтервалу
int n = 1000; // Кількість трапецій

double result = integralCalculator.CalculateIntegral(func, a, b, n);

Console.WriteLine($"Значення інтеграла: {result}");