using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Observer;

public class Publisher : IPublisher
{
	public List<ISubscriber> Subscribers { 
        get;
        private set;
    } = new ();
	
	public void Subscribe(ISubscriber subscriber){
		this.Subscribers.Add(subscriber);
	}
	
	public void Unsubscribe(ISubscriber subscriber){
		this.Subscribers.Remove(subscriber);
	}
	
	public void NotifySubscribers(){
		foreach(var subs in this.Subscribers)
			subs.Update(this);
	}
	
	public void BussinessAction(){
		this.NotifySubscribers();
	}
}
