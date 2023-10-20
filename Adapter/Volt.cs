using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter;

public class Volt
{
    public int Volts { get; set; }
    public Volt(int volts)
    {
        this.Volts = volts;
    }
}
