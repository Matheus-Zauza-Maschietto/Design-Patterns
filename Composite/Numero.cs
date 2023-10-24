using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Composite;

public class Numero: ISomador
{
    public int Valor { get; set; }
    public Numero(int valor)
    {
        Valor = valor;
    }

    public double Somar(){
        return Valor;
    }
}
