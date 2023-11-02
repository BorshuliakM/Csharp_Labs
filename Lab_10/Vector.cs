namespace Lab_10;

class Vector
{
    private double[] values;

    public Vector(int length)
    {
        values = new double[length];
    }

    public Vector(double[] values)
    {
        this.values = values;
    }

    public int Length
    {
        get { return values.Length; }
    }

    public double this[int index]
    {
        get { return values[index]; }
        set { values[index] = value; }
    }

    public static Vector operator +(Vector v1, Vector v2)
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
    public static Vector operator +(Vector v, double number)
    {
        Vector result = new Vector(v.Length);
        for (int i = 0; i < v.Length; i++)
        {
            result[i] = v[i] + number;
        }
        return result;
    }
}