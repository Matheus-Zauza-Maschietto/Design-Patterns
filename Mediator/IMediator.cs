using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Mediator;
public interface IMediator 
{
	void Notify(object sender, string ev);
}