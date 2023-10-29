namespace Lab_4;

public class Text
{
    public string Title { get; set; }
    public List<Sentence> Sentences { get; set; }
    public Text(string title)
    {
        Title = title;
        Sentences = new List<Sentence>();
    }
    public void AddSentence(Sentence sentence)
    {
        Sentences.Add(sentence);
    }
    public void PrintText()
    {
        Console.WriteLine($"Title: {Title}");
        foreach (var sentence in Sentences)
        {
            Console.WriteLine(sentence);
        }
    }
    public override bool Equals(object obj)
    {
        if (obj is Text otherText)
        {
            return Title.Equals(otherText.Title, StringComparison.OrdinalIgnoreCase)
                && Sentences.SequenceEqual(otherText.Sentences);
        }
        return false;
    }
    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + Title.ToLower().GetHashCode();
        foreach (var sentence in Sentences)
        {
            hash = hash * 23 + sentence.GetHashCode();
        }
        return hash;
    }
    public override string ToString()
    {
        return $"Title: {Title}\n{string.Join("\n", Sentences)}";
    }
}