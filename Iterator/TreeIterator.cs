using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator;

public class TreeIterator<T>: Iterator
{
    private readonly SortedSet<T> _collection;
    private int index = -1;
    public TreeIterator(SortedSet<T> collection)
    {
        _collection = collection;
    }

    public object? GetNext(){
        index++;
        int internalIndex = 0;
        foreach(var item in _collection){
            if(internalIndex == index)
                return (T)item;
            internalIndex++;
        }   

        return null;
    }

    public bool HasMore() => _collection.Count-1 == index+1;
}
