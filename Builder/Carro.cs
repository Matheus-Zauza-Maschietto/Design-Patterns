using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Builder;

public class Carro
{
    public int Portas { get; set; }
    public int Cavalos { get; set; }
    public Marcas Marca { get; set; }
    public bool HasVidroEletrico { get; set; }
    public bool HasDirecaoHidraulica { get; set; }

    public Carro(CarroBuilder builder){
        this.Portas = builder.Portas;
        this.Cavalos = builder.Cavalos;
        this.Marca = builder.Marca;
        this.HasDirecaoHidraulica = builder.HasDirecaoHidraulica;
        this.HasVidroEletrico = builder.HasVidroEletrico;
    }


    public class CarroBuilder{
        public int Portas { get; set; }
        public int Cavalos { get; set; }
        public Marcas Marca { get; set; }
        public bool HasVidroEletrico { get; set; }
        public bool HasDirecaoHidraulica { get; set; }

        public CarroBuilder(int portas, int cavalos, Marcas marca)
        {
            this.Portas = portas;
            this.Cavalos = cavalos;
            this.Marca = marca;
        }

        public CarroBuilder SetHasVidroEletrico(bool hasVidroEletrico)
        {
            this.HasDirecaoHidraulica = hasVidroEletrico;
            return this;
        }

        public CarroBuilder SetHasDirecaoHidraulica(bool hasDirecaoHidraulica)
        {
            this.HasVidroEletrico = hasDirecaoHidraulica;
            return this;
        }

        public Carro Build() => new (this);
        
    }
}
