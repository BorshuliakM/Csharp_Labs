using Lab_4;

Word word = new("I");
Word word2 = new("Will");
Word word3 = new("Do");
Word word4 = new("Something");
Sentence sentence = new();
sentence.AddWord(word);
sentence.AddWord(word2);
sentence.AddWord(word3);
sentence.AddWord(word4);
Text text = new("Some title");
Text text2 = new("Some title");
text2.AddSentence(sentence);
text.AddSentence(sentence);
text.PrintText();
Console.WriteLine(text.ToString());
Console.WriteLine(text.GetHashCode());
text.Equals(text2);

//Task 2
Console.WriteLine("Task 2");
Console.Write("Enter the number of prisms (m): ");
int m = Convert.ToInt32(Console.ReadLine());

TPrism[] prisms = new TPrism[m];

for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Enter the dimensions for Prism {i + 1} (length, width, and height):");
    double length = Convert.ToDouble(Console.ReadLine());
    double width = Convert.ToDouble(Console.ReadLine());
    double height = Convert.ToDouble(Console.ReadLine());

    if (i % 2 == 0)
    {
        prisms[i] = new TPrism3(length, width, height);
    }
    else
    {
        prisms[i] = new TPrism4(length, width, height);
    }
}

double totalTriangularVolume = 0;
double totalQuadrilateralSurfaceArea = 0;

foreach (TPrism prism in prisms)
{
    if (prism is TPrism3)
    {
        totalTriangularVolume += prism.GetVolume();
    }
    else if (prism is TPrism4)
    {
        totalQuadrilateralSurfaceArea += prism.GetSurfaceArea();
    }
}

Console.WriteLine($"Total Triangular Prism Volume: {totalTriangularVolume}");
Console.WriteLine($"Total Quadrilateral Prism Surface Area: {totalQuadrilateralSurfaceArea}");
