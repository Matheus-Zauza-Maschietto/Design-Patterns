using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator;

public class CoffeeSugar: CoffeeDecorator
{
    public CoffeeSugar(ICoffee _wrappee): base(_wrappee)
    {
        
    }

    public override string Describe()
    {
        return Wrappee.Describe()+", Açucar";
    }

    public override double Price()
    {
        return Wrappee.Price()+0.5;
    }
}
