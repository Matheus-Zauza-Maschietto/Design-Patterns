using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Bridge;

public class Aparelho
{
    public IDispositivo DispositivoEletrônico { get; set; }

    public Aparelho(IDispositivo dispositivo)
    {
        DispositivoEletrônico = dispositivo;
    }

    public void ColocarEmStandBy(){
        DispositivoEletrônico.Ligar();
        DispositivoEletrônico.DesligarTela();
    }

    public void ForcarDesligamento(){
        DispositivoEletrônico.Desligar();
    }

    public void DesligamentoSeguro(){
        DispositivoEletrônico.SairDaInternet();
        DispositivoEletrônico.DesligarTela();
        DispositivoEletrônico.Desligar();
    }

    public void IniciamentoRapido(){
        DispositivoEletrônico.Ligar();
        DispositivoEletrônico.LigarTela();
        DispositivoEletrônico.AcessarInternet();
    }

    public void IniciamentoSimples(){
        DispositivoEletrônico.Ligar();
        DispositivoEletrônico.LigarTela();
    }
}
