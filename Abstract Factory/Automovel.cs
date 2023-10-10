using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory;

public class Automovel
{
    public int NumeroRodas { get; set; }
    public string Placa { get; set; }
    public Automovel(string placa, int numeroRodas){
        this.NumeroRodas = numeroRodas;
        this.Placa = placa;
    }
}
