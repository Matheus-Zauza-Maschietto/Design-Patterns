using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy;

public class ConsoleStrategy : IStrategy
{
    public void Execute(string data){
        System.Console.WriteLine(data);
    }
}
