using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.TemplateMethod;

public abstract class RelatorioTemplate
{
    public string TemplateMethod(){
        string dados = this.ColetarDados();
        this.AnalisarDados(dados);
        return FormatarRelatorio(dados);
    }

    public abstract string ColetarDados();

    public abstract void AnalisarDados(string dados);

    public abstract string FormatarRelatorio(string dados);
}
