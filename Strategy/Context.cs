using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy;

public class Context
{
    private IStrategy Strategy { get; set; }

    public Context()
    {
        
    }

    public void SetStrategy(IStrategy strategy){
        this.Strategy = strategy;
    }

    public void ExecuteStrategy(string data){
        this.Strategy.Execute(data);
    }
}
