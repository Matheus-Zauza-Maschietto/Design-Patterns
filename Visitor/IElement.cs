using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Visitor;

public interface IElement {
	void Accept(IVisitor visitor);
}
