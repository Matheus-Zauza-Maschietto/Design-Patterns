using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor;

public class Visitor : IVisitor
{
    public void Visit(Car car){
        System.Console.WriteLine("Visitor from car");
        System.Console.WriteLine(car.CarName);
    }

    public void Visit(Truck truck){
        System.Console.WriteLine("Visitror from truck");
        System.Console.WriteLine(truck.TruckName);
    }
}
