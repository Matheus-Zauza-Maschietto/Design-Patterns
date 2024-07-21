using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Observer;

public interface ISubscriber
{
	void Update(IPublisher publisher);
}
