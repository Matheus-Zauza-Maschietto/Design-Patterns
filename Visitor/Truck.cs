using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor;

public class Truck : IElement {
	public string TruckName { get; set; }
    public Truck(string truckName)
    {
        this.TruckName = truckName;
    }

    public Truck() { }
    
    public void Accept(IVisitor visitor){
		visitor.Visit(this);
	}
	
}
