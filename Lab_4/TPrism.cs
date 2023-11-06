namespace Lab_4;

public abstract class TPrism//Абстрактний клас призми
{
    protected double length;
    protected double width;
    protected double height;

    public TPrism(double length, double width, double height)//конструктор в який предаються довжина ширина висота
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public abstract double GetSurfaceArea();//Найти площу поверхні
    public abstract double GetVolume();//Я не шарю в математику це щось
    public abstract void DisplayInfo();//Вивід інформації
}
