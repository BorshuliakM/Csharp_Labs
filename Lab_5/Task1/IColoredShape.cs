namespace Lab_5.Task1;

public interface IColoredShape : IShape//Кольорова форма
{
    string Color { get; set; }//Властивість колір
    void PrintColor();//Прінт кольору
}



