using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor;

public class Car : IElement {
    public string CarName { get; set; }

    public Car(string carName)
    {
        this.CarName = carName;
    }

    public Car() { }

	public void Accept(IVisitor visitor){
		visitor.Visit(this);
	}

}
