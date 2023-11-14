using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Decorator;

public interface ICoffee
{
    string Describe();
    double Price();    
}
