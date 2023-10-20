using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge;

    public interface IDispositivo
    {
        abstract void Desligar();
        abstract void Ligar();
        abstract void AcessarInternet();
        abstract void SairDaInternet();
        abstract void DesligarTela();
        abstract void LigarTela();
    }
