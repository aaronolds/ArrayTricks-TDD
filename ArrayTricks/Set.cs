using System;

public class Set
{
    private string[] _set;

    public Set(int size = 10)
    {
        _set = new string[size];
    }

    public int Size { get; set; } = 0;

    public bool isEmpty()
    {
        return Size == 0;
    }

    public void add(string elem)
    {
        if (indexOf(elem) >= 0) return;

        if (_set.Length == Size)
        {
            Array.Resize<string>(ref _set, Size + 1);
        }

        _set[Size++] = elem;
    }

    public int indexOf(string elem)
    {
        for (int i = 0; i < Size; i++)
        {
            if (_set[i].Equals(elem)) return i;
        }
        return -1;
    }

    public bool contains(string elem)
    {
        return indexOf(elem) >= 0;
    }

    public void remove(string elem)
    {
        if (Size == 0) return;
        int i = 0;
        for (int j = 0; j < Size; j++)
        {
            if (_set[j] != elem)
            {
                _set[i] = _set[j];
                i++;
            }
            Size--;
        }
    }
}