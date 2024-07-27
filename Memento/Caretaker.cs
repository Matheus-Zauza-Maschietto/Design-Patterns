using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Memento;
public class Caretaker
{
    private Originator Originator { get; set; }
    public  List<Memento> History { get; private set; } = new List<Memento>();

    public Caretaker(Originator originator)
    {
        Originator = originator;
    }


    public void Undo()
    {
        History.RemoveAt(History.Count-1);
        Originator.Restore(History.LastOrDefault());
    }
}