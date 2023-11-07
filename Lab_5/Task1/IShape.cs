namespace Lab_5.Task1;

public interface IShape//інтерфейс абстрактної форми
{
    void PrintShapeType();//Вивід типу форми
    void PrintArea();//Вивід площі
    double FirstLinearDimension { get; set; }//Перший лінійний вимір властивість
}