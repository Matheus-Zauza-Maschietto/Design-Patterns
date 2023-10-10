using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.AbstractFactory;

public class Carro : Automovel
{
    public int QuantidadeCavalos {get; set;}
    public int QuantidadePortas {get; set;}
    public Carro(int numeroRodas, string placa, int quantidadeCavalos, int quantidadePlacas) : base(placa, numeroRodas)
    {
        this.QuantidadeCavalos = quantidadeCavalos;
        this.QuantidadePortas = quantidadePlacas;
    }
}
