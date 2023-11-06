namespace Lab_4;

public class Text
{
    public string Title { get; set; }//Заголовок тексту
    public List<Sentence> Sentences { get; set; }//Список речень
    public Text(string title)
    {
        Title = title;
        Sentences = new List<Sentence>();
    }
    public void AddSentence(Sentence sentence)//Додати речення
    {
        Sentences.Add(sentence);
    }
    public void PrintText()//Друк тексту
    {
        Console.WriteLine($"Title: {Title}");
        foreach (var sentence in Sentences)
        {
            Console.WriteLine(sentence);
        }
    }
    public override bool Equals(object obj)//Метод порівняння
    {
        if (obj is Text otherText)
        {
            return Title.Equals(otherText.Title, StringComparison.OrdinalIgnoreCase)
                && Sentences.SequenceEqual(otherText.Sentences);
        }
        return false;
    }
    public override int GetHashCode()//Метод для повернення хешкоду екземпляру
    {
        int hash = 17;
        hash = hash * 23 + Title.ToLower().GetHashCode();
        foreach (var sentence in Sentences)
        {
            hash = hash * 23 + sentence.GetHashCode();
        }
        return hash;
    }
    public override string ToString() //Перевизначений метод тустрінг
    {
        return $"Title: {Title}\n{string.Join("\n", Sentences)}";
    }
}