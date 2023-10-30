namespace Lab_4;

public abstract class TPrism
{
    protected double length;
    protected double width;
    protected double height;

    public TPrism(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public abstract double GetSurfaceArea();
    public abstract double GetVolume();
    public abstract void DisplayInfo();
}
