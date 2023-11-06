namespace Lab_4;

public class Word
{
    public string Text { get; set; }//Поле для зберігання слова
    public Word(string text)
    {
        Text = text;
    }
    public override bool Equals(object obj)//Метод порівняння чи є щось словом
    {
        if (obj is Word otherWord)
        {
            return Text.Equals(otherWord.Text, StringComparison.OrdinalIgnoreCase);
        }
        return false;
    }
    public override int GetHashCode()//Метод який повертає хешкод
    {
        return Text.ToLower().GetHashCode();
    }
    public override string ToString()//Тустрінг метод
    {
        return Text;
    }
}
