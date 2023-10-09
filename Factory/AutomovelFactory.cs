using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Factory;

public class AutomovelFactory
{
    public static Automovel? GetAutomovel(string tipo){
        if(tipo.Equals(nameof(Carro)))
            return new Carro(4, "jdgjnre", 500, 2);
        else if(tipo.Equals(nameof(Moto)))
            return new Moto(2, "48fmwo", 100, 0);
        return null;
    }
}
