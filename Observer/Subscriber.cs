using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Observer;

public class Subscriber : ISubscriber
{
    public void Update(IPublisher publisher)
    {
        Console.WriteLine("Executando algo");
    }
}
