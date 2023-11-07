using System;
using System.Collections;
using System.Collections.Generic;
namespace Lab_6;

public class CollectionType<T> : ICollection<T>//Клас колкшн тайп реалізує інтерфейс іколекшн
{
    private List<T> items;//список для зберігання елементів

    public CollectionType()
    {
        items = new List<T>();
    }

    public void Add(T item)//Додати елемент
    {
        items.Add(item);
    }

    public bool Remove(T item)//Прибрати елемент
    {
        return items.Remove(item);
    }

    public void Clear()//Очистити список
    {
        ((ICollection<T>)items).Clear();
    }

    public bool Contains(T item)//Метод який перевіряє чи включає в себе якийсь елемент список нашої колекції
    {
        return ((ICollection<T>)items).Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)//Метод копіювання
    {
        ((ICollection<T>)items).CopyTo(array, arrayIndex);
    }

    public IEnumerator<T> GetEnumerator()//Метод який повертає енумератор
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

    public int Count//Кількість елементів
    {
        get { return items.Count; }
    }

    public void Sort()//Сортування
    { 
        items.Sort(); 
    }

    public bool IsReadOnly => ((ICollection<T>)items).IsReadOnly;//Чи є список тільки для читання
}
