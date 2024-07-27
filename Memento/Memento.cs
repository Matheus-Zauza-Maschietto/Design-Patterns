using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Memento;

public class Memento {
	public string State { get; private set; }
	public Memento(string state) {
		State = state;
	}
}