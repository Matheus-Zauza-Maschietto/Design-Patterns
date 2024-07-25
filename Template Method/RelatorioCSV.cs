using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.TemplateMethod;

public class RelatorioCSV : RelatorioTemplate
{
    public override string ColetarDados()
    {
        return "MEU CSV";
    }

    public override void AnalisarDados(string dados)
    {
        System.Console.WriteLine("Analisando csv");
    }

    public override string FormatarRelatorio(string dados)
    {
        return string.Join(";", dados.Split(" "));
    }
}
