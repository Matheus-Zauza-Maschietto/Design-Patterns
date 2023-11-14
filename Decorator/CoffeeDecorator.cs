using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator;

public class CoffeeDecorator: ICoffee
{
    public ICoffee Wrappee { get; set; }

    public CoffeeDecorator(ICoffee _wrappee)
    {
        Wrappee = _wrappee;
    }

    public virtual string Describe()
    {
        return Wrappee.Describe();
    }

    public virtual double Price()
    {
        return Wrappee.Price();
    }
}
