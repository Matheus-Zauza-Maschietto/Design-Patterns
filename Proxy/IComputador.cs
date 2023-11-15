using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy;

public interface IComputador
{
    void Ligar();
    void Desligar();
    void AbrirNavegador();
    void FecharNavegador();
}
