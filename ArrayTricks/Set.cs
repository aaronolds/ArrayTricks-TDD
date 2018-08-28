using System;

public class Set
{
    private int _size = 0;
    private string[] _set = new string[10];
    
    public bool isEmpty()
    {
        return _size == 0;
    }
    
    public void add(string elem)
    {
        _set[_size++] = elem;
    }

    public void remove(string elem)
    {
        if (_size == 0) return;
        int i = 0;
        for (int j = 0; j < _size; j++)
        {
            if (_set[j] != elem)
            {
                _set[i] = _set[j];
                i++;
            }
        }
    }
}