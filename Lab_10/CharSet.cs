namespace Lab_10;
public class CharSet
{
    private HashSet<char> elements = new HashSet<char>();

    public void Add(char element)
    {
        elements.Add(element);
    }

    public static CharSet operator +(CharSet set, char element)
    {
        // Створюємо новий об'єкт CharSet, який містить всі елементи початкової множини та новий елемент.
        CharSet newSet = new CharSet();
        foreach (char item in set.elements)
        {
            newSet.Add(item);
        }
        newSet.Add(element);
        return newSet;
    }

    public static CharSet operator +(CharSet set1, CharSet set2)
    {
        // Створюємо новий об'єкт CharSet, який містить об'єднання двох множин.
        CharSet newSet = new CharSet();
        foreach (char item in set1.elements)
        {
            newSet.Add(item);
        }
        foreach (char item in set2.elements)
        {
            newSet.Add(item);
        }
        return newSet;
    }

    public static bool operator ==(CharSet set1, CharSet set2)
    {
        if (ReferenceEquals(set1, set2))
            return true;

        if (set1 is null || set2 is null)
            return false;

        return set1.elements.SetEquals(set2.elements);
    }

    public static bool operator !=(CharSet set1, CharSet set2)
    {
        return !(set1 == set2);
    }

    public override bool Equals(object obj)
    {
        if (obj is CharSet otherSet)
            return this == otherSet;
        return false;
    }

    public override int GetHashCode()
    {
        return elements.GetHashCode();
    }
}