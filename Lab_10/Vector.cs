namespace Lab_10;

public class Vector//Клас вектору
{
    private double[] values;// за основу взято масив

    public Vector(int length)
    {
        values = new double[length];
    }

    public Vector(double[] values)
    {
        this.values = values;
    }

    public int Length//метод який повертає довжину
    {
        get { return values.Length; }
    }

    public double this[int index]
    {
        get { return values[index]; }
        set { values[index] = value; }
    }

    public static Vector operator +(Vector v1, Vector v2)//перенавантажуєм оператор + (вектор + вектор)
    {
        if (v1.Length != v2.Length)
            throw new ArgumentException("Vectors must have the same length");

        Vector result = new Vector(v1.Length);
        for (int i = 0; i < v1.Length; i++)
        {
            result[i] = v1[i] + v2[i];
        }
        return result;
    }
    public static Vector operator +(Vector v, double number)//перенавантажуєм оператор + (вектор + число)
    {
        Vector result = new Vector(v.Length);
        for (int i = 0; i < v.Length; i++)
        {
            result[i] = v[i] + number;
        }
        return result;
    }
    public void Print()
    {
        foreach (double v in values)
        {
            Console.WriteLine(v.ToString());
        }
    }
}