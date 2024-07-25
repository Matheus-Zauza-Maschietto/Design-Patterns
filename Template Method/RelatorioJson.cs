using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.TemplateMethod;

public class RelatorioJson : RelatorioTemplate
{
    public override void AnalisarDados(string dados)
    {
        System.Console.WriteLine("Analisando dados json");
    }

    public override string ColetarDados()
    {
        return "Dados json";
    }

    public override string FormatarRelatorio(string dados)
    {
        return "{\"dados\": " + dados + "}";
    }
}
