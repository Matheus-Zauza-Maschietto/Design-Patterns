using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Design_Patterns.ChainofResponsability;

    public class EmailValidator: LoginValidatorBase
    {
    public override void Execute(Login login)
    {
        string pattern = @"\w{3,}@\w+(\.\w+)*";
        if(Regex.IsMatch(login.Email, pattern)){
            System.Console.WriteLine("Passou no teste de email");
            this.next?.Execute(login);
        }
    }
}
