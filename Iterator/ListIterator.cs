using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator;

public class ListIterator<T>: Iterator
{
    private readonly List<T> _collection;
    private int index = -1;
    public ListIterator(List<T> collection)
    {
        _collection = collection;
    }

    public object? GetNext(){
        this.index++;
        return (T)_collection[index];
    }

    public bool HasMore() => _collection.Count-1 == index+1;
}
