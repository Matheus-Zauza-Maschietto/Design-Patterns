using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter
{
    public interface ISocketAdapter
    {
        public Volt Get120Volt();
        public Volt Get12Volt();
        public Volt Get3Volt();
    }
}