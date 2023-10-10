using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Design_Patterns.AbstractFactory;

namespace Design_Patterns.AbstractFactory;

public class CarroFactory : IAbstractFactory
{
    public CarroFactory(){}
    public Automovel? CreateAutomovel(string tipoDeUso){
        if(tipoDeUso == "Profissional"){
            return new Carro(4, "aaa2532", 700, 10);
        }
        else if(tipoDeUso ==  "Casual"){
            return new Carro(4, "34352fa", 150, 2);
        }
        return null;
    }
}
