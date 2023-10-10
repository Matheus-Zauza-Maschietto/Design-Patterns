using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory;

public class MotoFactory : IAbstractFactory
{
    public MotoFactory(){}
    public Automovel? CreateAutomovel(string tipoDeUso){
        if(tipoDeUso == "Profissional"){
            return new Moto(2, "vnwiuwe", 125, 2);
        }
        else if(tipoDeUso == "Casual"){
            return new Moto(2, "eqffoq", 350, 4);
        }
        return null;
    }
}
