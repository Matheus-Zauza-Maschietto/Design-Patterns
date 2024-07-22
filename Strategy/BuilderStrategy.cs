using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy;

public class BuilderStrategy : IStrategy
{
    public void Execute(string data){
        StringBuilder builder = new StringBuilder();
        builder.Append(data);
        System.Console.WriteLine(builder.ToString());
    }
}
