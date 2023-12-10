using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.ChainofResponsability;

    public class IdadeValidator: LoginValidatorBase
    {
    public override void Execute(Login login)
    {
        if(login.Idade >= 18 && login.Idade < 99){
            System.Console.WriteLine("Passou no teste de idade");
            this.next?.Execute(login);
        }
    }
}
