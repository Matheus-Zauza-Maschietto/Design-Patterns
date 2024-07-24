using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor;

public interface IVisitor {
	void Visit(Car car);
	void Visit(Truck truck);
}