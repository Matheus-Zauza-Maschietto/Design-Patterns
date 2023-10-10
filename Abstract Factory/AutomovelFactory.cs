using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory;

public class AutomovelFactory
{
    public static Automovel? GetAutomovel(IAbstractFactory factory, string tipoDeUso){
        return factory.CreateAutomovel(tipoDeUso);
    }
}
