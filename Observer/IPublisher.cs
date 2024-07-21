using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Observer;

public interface IPublisher
{
	List<ISubscriber> Subscribers {
        get;
    }
	void Subscribe(ISubscriber subscriber);
	void Unsubscribe(ISubscriber subscriber);
	void NotifySubscribers();

}
