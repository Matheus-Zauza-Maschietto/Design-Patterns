using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Mediator;

public class Mediator : IMediator {
	public ComponentA ComponentA { get; set; }
	public ComponentB ComponentB { get; set; }
	public ComponentC ComponentC { get; set; }
	
	public Mediator (ComponentA componentA, ComponentB componentB, ComponentC componentC)
	{
		ComponentA = componentA;
        componentA.SetMediator(this);
		ComponentB = componentB;
        componentB.SetMediator(this);
		ComponentC = componentC;
        componentC.SetMediator(this);
	}
	
	public void Notify(object sender, string ev){
		if(ev == "A")
		{
			ReactOnComponentA();
		}
		else if(ev == "B")
		{
			ReactOnComponentB();
		}
		else if(ev == "C")
        {
			ReactOnComponentB();
		}
        else if(ev == "D")
        {
			ReactOnComponentC();
		}
        else if(ev == "E")
        {
			ReactOnComponentC();
		}
        else if(ev == "F")
        {
			ReactOnComponentC();
		}
	}
	
	private void ReactOnComponentA()
	{
		Console.WriteLine("Faça algo pelo componente A");
	}
	
	private void ReactOnComponentB()
	{
		Console.WriteLine("Faça algo pelo componente B");
	}
	
	private void ReactOnComponentC()
	{
		Console.WriteLine("Faça algo pelo componente C");
	}
}