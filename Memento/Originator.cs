using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Memento;

public class Originator {
	public string State { get; private set; }
	
	public Originator(string initialState){
        State = initialState;
    }
	
    public void SetNewState(string state){
        State = state;
    }

	public Memento Save()
	{
		return new Memento(this.State);
	}
	
	public void Restore(Memento? memento)
	{
        if(memento is not null)
		    this.State = memento.State;
	}
}
