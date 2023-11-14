using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator;

public class CoffeeMilk: CoffeeDecorator
{
    public CoffeeMilk(ICoffee _wrappee): base(_wrappee)
    {
        
    }

    public override string Describe()
    {
        return Wrappee.Describe()+", Leite";
    }

    public override double Price()
    {
        return Wrappee.Price()+2;
    }
}
