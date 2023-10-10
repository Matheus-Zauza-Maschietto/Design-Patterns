using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory;

public interface IAbstractFactory
{
    public Automovel? CreateAutomovel(string tipoDeUso);
}
