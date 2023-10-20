using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge
{
    public class Computador : IDispositivo
    {
        public bool IsComputerOn { get; set; }
        public bool IsComputerScreenOn { get; set; }
        public bool IsComputerAtInternet { get; set; }
        public void Ligar(){
            this.IsComputerOn = true;
        }   
        public void Desligar(){
            this.IsComputerOn = false;
        }
        public void AcessarInternet(){
            this.IsComputerScreenOn = true;
        }
        public void SairDaInternet(){
            this.IsComputerScreenOn = false;
        }

        public void DesligarTela(){
            this.IsComputerAtInternet = false;
        }

        public void LigarTela(){
            this.IsComputerAtInternet = false;
        }
    }
}