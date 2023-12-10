using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.ChainofResponsability;

    public class SenhaValidator: LoginValidatorBase
    {
    public override void Execute(Login login)
    {
        if(login.Senha == "123312412416929"){
            System.Console.WriteLine("Passou no teste de senha");
            this.next?.Execute(login);
        }
    }
}
