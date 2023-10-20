using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Adapter;

public class SocketClassAdapterImpl : Socket, ISocketAdapter
{
    public Volt Get120Volt(){
        return GetVolt();
    }

    public Volt Get12Volt(){
        Volt v = GetVolt();
        return convertVolt(v, 10);
    }

    public Volt Get3Volt(){
        Volt v = GetVolt();
        return convertVolt(v, 40);
    } 

    private Volt convertVolt(Volt v, int i){
        return new Volt(v.Volts/i);
    }
}
