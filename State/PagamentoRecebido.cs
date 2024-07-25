using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.State;
public class PagamentoRecebido: IState {
	private Context Context { get; set; }
	
	public PagamentoRecebido(Context context){
		this.Context = context;
	}
	
	public void InserirMoeda(){
		Console.WriteLine("Uma moeda já foi inserida");
	}
	
	public void SelecionarMoeda(){
		Console.WriteLine("Um item ja foi selecionado");
	}
	
	public void DispensarMoeda(){
		Console.WriteLine("Moeda despensada");
		this.Context.ChangeState(new ProntoParaComprar(this.Context));
	}
}