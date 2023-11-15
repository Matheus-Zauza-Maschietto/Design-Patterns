using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy;

public class Computador: IComputador
{
    public bool IsOn { get; set; }
    public bool NavegadorIsOn { get; set; }

    public Computador()
    {
        
    }

    public void Ligar(){
        System.Console.WriteLine("Computador ligando ...");
        Thread.Sleep(1000);
        IsOn = true;
        System.Console.WriteLine("Computador ligou.");
    }

    public void Desligar(){
        System.Console.WriteLine("Computador desligando ...");
        Thread.Sleep(1000);
        IsOn = false;
        System.Console.WriteLine("Computador desligou.");
    }

    public void AbrirNavegador(){
        System.Console.WriteLine("Navegador abrindo ...");
        Thread.Sleep(1000);
        NavegadorIsOn = true;
        System.Console.WriteLine("Nvageador aberto.");
    }

    public void FecharNavegador(){
        System.Console.WriteLine("Navegador fechando ...");
        Thread.Sleep(1000);
        NavegadorIsOn = false;
        System.Console.WriteLine("Navegador fechado.");
    }
}
