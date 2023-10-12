using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Prototype;

public class Pessoa : ICloneble
{
    public int Idade { get; set; }
    public string Nome { get; set; }
    public IEnumerable<string> Sobrenomes { get; set; }

    public Pessoa(){}

    public Pessoa(int idade, string nome, IEnumerable<string> sobrenomes){
        Idade = idade;
        Nome = nome;
        Sobrenomes = sobrenomes;
    }

    public Object Clone(){
        Pessoa deepClone = new();
        deepClone.Idade = this.Idade;
        deepClone.Nome = this.Nome;
        this.Sobrenomes.Select(item => deepClone.Sobrenomes.Append(item));
        return deepClone;
    }
}
