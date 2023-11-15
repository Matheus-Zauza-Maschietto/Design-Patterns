using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy;

public class ComputadorProxy: IComputador
{
    private Computador Computador = new ();

    public void Ligar(){
        if(!Computador.IsOn)
            Computador.Ligar();
    }

    public void Desligar(){
        if(Computador.IsOn)
            Computador.Desligar();
    }

    public void AbrirNavegador(){
        if(!Computador.NavegadorIsOn)
            Computador.AbrirNavegador();
    }

    public void FecharNavegador(){
        if(Computador.NavegadorIsOn)
            Computador.FecharNavegador();
    }
}
