using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Flyweight;

public class Flyweight
{
    public readonly string Type;
    public readonly decimal Constante;
    public Flyweight(decimal constante, string type)
    {
        Type = type;
        Constante = constante;
    }
}
