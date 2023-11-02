namespace Lab_10;

public class CharList
{
    private List<char> elements = new List<char>();
    public void Add(char element)
    {
        elements.Add(element);
    }
    public void RemoveAt(int k)
    { 
        elements.RemoveAt(k); 
    }
    public static CharList operator +(CharList left, CharList right)
    {
        CharList newList = new CharList();
        foreach (char element in left.elements)
        {
            newList.Add(element);
        }
        foreach (char element in right.elements)
        {
            newList.Add(element);
        }
        return newList;
    }
    public static CharList operator --(CharList lst)
    {
        CharList newList = new CharList();
        foreach (char element in lst.elements)
        {
            newList.Add(element);
        }
        newList.RemoveAt(0);
        return newList;
    }
    public static bool operator ==(CharList left, CharList right)
    {
        if (ReferenceEquals(left, right))
            return true;
        if (left is null || right is null)
            return false;
        return left.elements.Equals(right.elements);
    }
    public static bool operator !=(CharList left, CharList right)
    {
        return !(left == right);
    }

    public override bool Equals(object obj)
    {
        if (obj is CharList otherList)
            return this == otherList;
        return false;
    }

    public override int GetHashCode()
    {
        return elements.GetHashCode();
    }
}
