using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator
{
    public interface IterableCollection
    {
        Iterator CreateListIterator();
        Iterator CreateTreeIterator();
    }
}