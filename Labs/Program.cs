using Lab_5.Task1;
using Lab_5.Task2;
using Lab_5.Task3;

IShape[] shapes = new IShape[]
{
    new Circle(5.0),
    new Circle(3.0),
    new Circle(2.0),
    new ColoredCircle(4.0, "Red"),
    new ColoredCircle(6.0, "Blue"),
    new ColoredCircle(2.5, "Green")
};

foreach (IShape shape in shapes)
{
    shape.PrintShapeType();
    shape.PrintArea();
    Console.WriteLine($"First Linear Dimension: {shape.FirstLinearDimension}");

    if (shape is IColoredShape coloredShape)
    {
        coloredShape.PrintColor();
    }

    Console.WriteLine();
}
//Task 2
IPrintable[] printable = new IPrintable[]
{
     new Book("Book 1"),
     new Magazine("Magazine 1"),
     new Book("Book 2"),
     new Magazine("Magazine 2"),
     new Magazine("Magazine 3"),
     new Book("Book 3")
};
Console.WriteLine("All Printable Items:");
foreach (IPrintable item in printable)
{
    item.Print();
}

Console.WriteLine("\nMagazines Only:");
Magazine.printMagazines(printable);

Console.WriteLine("\nBooks Only:");
Book.printBooks(printable);
//Task 3
Shop[] sizes = new Shop[]
        {
            new Shop(ClothingSize.XXS, 32),
            new Shop(ClothingSize.XS, 34),
            new Shop(ClothingSize.S, 36),
            new Shop(ClothingSize.M, 38),
            new Shop(ClothingSize.L, 40),
        };

IMaleClothing[] maleClothes = new IMaleClothing[]
{
            new TShirt(ClothingSize.S, 25.0m, "Blue"),
            new Pants(ClothingSize.M, 40.0m, "Black"),
            new Tie(ClothingSize.L, 15.0m, "Red"),
};

IFemaleClothing[] femaleClothes = new IFemaleClothing[]
{
            new TShirt(ClothingSize.XS, 20.0m, "Pink"),
            new Pants(ClothingSize.S, 35.0m, "Gray"),
            new Skirt(ClothingSize.M, 30.0m, "Blue"),
};

Atelier atelier = new Atelier();
atelier.DressWoman(femaleClothes);
atelier.DressMan(maleClothes);