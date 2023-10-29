namespace Lab_4;

public class Word
{
    public string Text { get; set; }
    public Word(string text)
    {
        Text = text;
    }
    public override bool Equals(object obj)
    {
        if (obj is Word otherWord)
        {
            return Text.Equals(otherWord.Text, StringComparison.OrdinalIgnoreCase);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Text.ToLower().GetHashCode();
    }
    public override string ToString()
    {
        return Text;
    }
}
