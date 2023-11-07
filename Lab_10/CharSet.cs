namespace Lab_10;
public class CharSet//Клас чарсету
{
    private HashSet<char> elements = new HashSet<char>();//за основу взятий хешсет

    public void Add(char element)//додати елеменет
    {
        elements.Add(element);
    }

    public static CharSet operator +(CharSet set, char element)//перенавантаження опреатору + (сет + елемент)
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

    public static CharSet operator +(CharSet set1, CharSet set2)//перенавантаження оператору + (сет + сет)
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

    public static bool operator ==(CharSet set1, CharSet set2)//перенавантаження оператору ==
    {
        if (ReferenceEquals(set1, set2))
            return true;

        if (set1 is null || set2 is null)
            return false;

        return set1.elements.SetEquals(set2.elements);
    }

    public static bool operator !=(CharSet set1, CharSet set2)//перенавантаження орператору !=
    {
        return !(set1 == set2);
    }

    public override bool Equals(object obj)//Метод порівняння
    {
        if (obj is CharSet otherSet)
            return this == otherSet;
        return false;
    }

    public override int GetHashCode()//метод повернення хешкоду
    {
        return elements.GetHashCode();
    }
    public void Print()
    {
        foreach (char v in elements)
        {
            Console.WriteLine(v);
        }
    }
}