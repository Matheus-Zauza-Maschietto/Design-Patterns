using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Factory;

public class Moto : Automovel
{
    public int Cilindradas { get; set; }
    public int QuantidadeMotor{ get; set; }

    public Moto(int quantidadeRodas, string placa, int cilindradas, int quantidadeMotor) : base(placa, quantidadeRodas){
        this.QuantidadeMotor = quantidadeMotor;
        this.Cilindradas = cilindradas;
    }
}
