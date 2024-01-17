using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator
{
    public interface Iterator
    {
        object? GetNext();
        bool HasMore();
    }
}