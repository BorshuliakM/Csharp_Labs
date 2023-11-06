namespace Lab_4;

public class Sentence
{
    public List<Word> Words { get; set; }//Список слів
    public Sentence()
    {
        Words = new List<Word>();
    }
    public void AddWord(Word word)//Додати слово до речення
    {
        Words.Add(word);
    }
    public override bool Equals(object obj)//Чи є щось реченням
    {
        if (obj is Sentence otherSentence)
        {
            return Words.SequenceEqual(otherSentence.Words);
        }
        return false;
    }
    public override int GetHashCode()//Хешкод
    {
        int hash = 17;
        foreach (var word in Words)
        {
            hash = hash * 23 + word.GetHashCode();
        }
        return hash;
    }
    public override string ToString()//Ту стрінг
    {
        return string.Join(" ", Words);
    }
}
