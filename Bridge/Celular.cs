using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge
{
    public class Celular: IDispositivo
    {
        
        public bool IsCelularOn { get; set; }
        public bool IsCelularScreenOn { get; set; }
        public bool IsCelularAtInternet { get; set; }
        public void Ligar(){
            this.IsCelularOn = true;
        }   
        public void Desligar(){
            this.IsCelularOn = false;
        }
        public void AcessarInternet(){
            this.IsCelularScreenOn = true;
        }
        public void SairDaInternet(){
            this.IsCelularScreenOn = false;
        }

        public void DesligarTela(){
            this.IsCelularAtInternet = false;
        }

        public void LigarTela(){
            this.IsCelularAtInternet = false;
        }
    }
}