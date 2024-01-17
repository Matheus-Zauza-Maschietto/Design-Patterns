using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator;

    public class ConcreteCollection<T>: IterableCollection
    {
        public ConcreteCollection(List<T> list, SortedSet<T> tree)
        {
            List = list;
            Tree = tree;
        }
        private List<T> List = new ();   
        private SortedSet<T> Tree = new ();
        public Iterator CreateListIterator(){
            return new ListIterator<T>(List);
        }

        public Iterator CreateTreeIterator(){
            return new TreeIterator<T>(Tree);
        }
    }
