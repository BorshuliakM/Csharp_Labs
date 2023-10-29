namespace Lab_4;

public class Sentence
{
    public List<Word> Words { get; set; }
    public Sentence()
    {
        Words = new List<Word>();
    }
    public void AddWord(Word word)
    {
        Words.Add(word);
    }
    public override bool Equals(object obj)
    {
        if (obj is Sentence otherSentence)
        {
            return Words.SequenceEqual(otherSentence.Words);
        }
        return false;
    }
    public override int GetHashCode()
    {
        int hash = 17;
        foreach (var word in Words)
        {
            hash = hash * 23 + word.GetHashCode();
        }
        return hash;
    }
    public override string ToString()
    {
        return string.Join(" ", Words);
    }
}
