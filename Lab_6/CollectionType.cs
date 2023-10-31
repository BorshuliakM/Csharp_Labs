using System;
using System.Collections;
using System.Collections.Generic;
namespace Lab_6;

public class CollectionType<T> : ICollection<T>
{
    private List<T> items;

    public CollectionType()
    {
        items = new List<T>();
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public bool Remove(T item)
    {
        return items.Remove(item);
    }

    public void Clear()
    {
        ((ICollection<T>)items).Clear();
    }

    public bool Contains(T item)
    {
        return ((ICollection<T>)items).Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        ((ICollection<T>)items).CopyTo(array, arrayIndex);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)items).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)items).GetEnumerator();
    }

    public T this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }

    public int Count
    {
        get { return items.Count; }
    }

    public void Sort()
    { 
        items.Sort(); 
    }

    public bool IsReadOnly => ((ICollection<T>)items).IsReadOnly;
}
