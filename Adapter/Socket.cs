using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter;

public class Socket
{
    public Volt GetVolt(){
        return new Volt(120);
    }
}
