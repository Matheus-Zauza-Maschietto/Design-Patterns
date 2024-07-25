using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.State;
public class ItemSelecionado: IState {
    
	private Context Context { get; set; }
	
	public ItemSelecionado(Context context){
		this.Context = context;
	}
	
	public void InserirMoeda(){
		Console.WriteLine("Uma moeda já foi inserida");
	}
	
	public void SelecionarMoeda(){
		Console.WriteLine("Item selecionado");
		this.Context.ChangeState(new PagamentoRecebido(this.Context));
	}
	
	public void DispensarMoeda(){
		Console.WriteLine("Item não selecionado");
	}
}