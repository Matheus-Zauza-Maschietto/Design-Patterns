using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.State;

public class Context : IState {
	private IState State { get; set; }
	
	public Context(){
        this.State = new ProntoParaComprar(this);
	}
	
	public void ChangeState(IState state){
		this.State = state;
	}
	
	public void InserirMoeda(){
		this.State.InserirMoeda();
	}
	
	public void SelecionarMoeda(){
		this.State.SelecionarMoeda();
	}
	
	public void DispensarMoeda(){
		this.State.DispensarMoeda();
	}
}
