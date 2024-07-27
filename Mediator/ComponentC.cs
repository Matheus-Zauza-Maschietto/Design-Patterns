using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Mediator;
        
public  class ComponentC : BaseComponent
{
    public void DoE()
    {
        Console.WriteLine("Component C does E.");

        this._mediator?.Notify(this, "E");
    }

    public void DoF()
    {
        Console.WriteLine("Component C does F.");

        this._mediator?.Notify(this, "F");
    }
}