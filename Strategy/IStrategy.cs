using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy;

public interface IStrategy
{
    void Execute(string data);
}
