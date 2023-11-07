using System.IO;
//Task 1
static void CreateDir(string path)//Створити диреторію
{
    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
}
static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
{
    // Get information about the source directory
    var dir = new DirectoryInfo(sourceDir);

    // Check if the source directory exists
    if (!dir.Exists)
        throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

    // Cache directories before we start copying
    DirectoryInfo[] dirs = dir.GetDirectories();

    // Create the destination directory
    Directory.CreateDirectory(destinationDir);

    // Get the files in the source directory and copy to the destination directory
    foreach (FileInfo file in dir.GetFiles())
    {
        string targetFilePath = Path.Combine(destinationDir, file.Name);
        file.CopyTo(targetFilePath);
    }

    // If recursive and copying subdirectories, recursively call this method
    if (recursive)
    {
        foreach (DirectoryInfo subDir in dirs)
        {
            string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
            CopyDirectory(subDir.FullName, newDestinationDir, true);
        }
    }
}
string lab_8 = @"D:\Kolya\Programming\OOP_Lab08",
Groupe = @"D:\Kolya\Programming\OOP_Lab08\KNms1-b23",
Surname = @"D:\Kolya\Programming\OOP_Lab08\Borshuliak",
Source = @"D:\Kolya\Programming\OOP_Lab08\Source",
Reports = @"D:\Kolya\Programming\OOP_Lab08\Reports",
Texts = @"D:\Kolya\Programming\OOP_Lab08\Texts";

CreateDir(lab_8);
CreateDir(Groupe);
CreateDir(Surname);
CreateDir(Source);
CreateDir(Reports);
CreateDir(Texts);

string Txt = Surname + @"\Texts",
Sourc = Surname + @"\Source",
Rep = Surname + @"\Reports";
CopyDirectory(Texts, Txt, true);
CopyDirectory(Source, Sourc, true);
CopyDirectory(Reports, Rep, true);

Directory.Move(Surname, Groupe+@"\Borshuliak");

string directoryPath = @"D:\Kolya\Programming\OOP_Lab08\KNms1-b23\Borshuliak\Texts"; // Назва каталогу

try
{
    // Перевіримо, чи каталог існує
    if (Directory.Exists(directoryPath))
    {
        // Отримаємо інформацію про каталог
        DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

        // Створимо текстовий файл для збереження інформації
        using (StreamWriter writer = new StreamWriter(Path.Combine(directoryPath, "dirinfo.txt")))
        {
            // Запишемо інформацію в текстовий файл
            writer.WriteLine($"Інформація про каталог: {directoryInfo.FullName}");
            writer.WriteLine($"Дата створення: {directoryInfo.CreationTime}");
            writer.WriteLine($"Останні зміни: {directoryInfo.LastWriteTime}");
            writer.WriteLine($"Кількість файлів: {directoryInfo.GetFiles().Length}");
            writer.WriteLine($"Кількість підкаталогів: {directoryInfo.GetDirectories().Length}");
        }

        Console.WriteLine("Інформація про каталог збережена в файлі dirinfo.txt.");
    }
    else
    {
        Console.WriteLine("Каталог не існує.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Помилка: {ex.Message}");
}

string filePath = @"C:\Users\Kola\Source\Repos\BorshuliakM\Csharp_Labs\f.txt"; // Шлях до файлу "f.txt"

if (File.Exists(filePath))
{
    try
    {
        double sum = 0;
        double product = 1;
        double sumOfSquares = 0;
        double lastComponent = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (double.TryParse(line, out double number))
                {
                    // 1) Сума компонент файлу
                    sum += number;

                    // 2) Добуток компонент файлу
                    product *= number;

                    // 3) Сума квадратів компонент файлу
                    sumOfSquares += number * number;

                    // 5) Остання компонента файлу
                    lastComponent = number;
                }
            }
        }

        // 4) Модуль суми і квадрат добутку компонент файлу
        double absSum = Math.Abs(sum);
        double squareOfProduct = product * product;

        Console.WriteLine($"1) Сума компонент файлу: {sum}");
        Console.WriteLine($"2) Добуток компонент файлу: {product}");
        Console.WriteLine($"3) Сума квадратів компонент файлу: {sumOfSquares}");
        Console.WriteLine($"4) Модуль суми і квадрат добутку компонент файлу: {absSum} та {squareOfProduct}");
        Console.WriteLine($"5) Остання компонента файлу: {lastComponent}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Помилка: {ex.Message}");
    }
}
else
{
    Console.WriteLine("Файл не існує.");
}
