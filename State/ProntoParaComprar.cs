using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.State;

public class ProntoParaComprar : IState {
	private Context Context { get; set; }
	
	public ProntoParaComprar(Context context){
		this.Context = context;
	}
	
	public void InserirMoeda(){
		Console.WriteLine("Moeda inserida, selecione um item");
		this.Context.ChangeState(new ItemSelecionado(this.Context));
	}
	
	public void SelecionarMoeda(){
		Console.WriteLine("Insira uma moeda para selecionar um item");
	}
	
	public void DispensarMoeda(){
		Console.WriteLine("Moeda não recebida.");
	}
}
