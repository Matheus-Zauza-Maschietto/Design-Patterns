using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Composite;

public class Conjunto: ISomador
{
    public IEnumerable<Numero> NumerosList { get; set; }
    public IEnumerable<Conjunto> ConjuntoList { get; set; }
    public Conjunto(IEnumerable<Numero> numerosList, IEnumerable<Conjunto> conjuntoList)
    {
        NumerosList = numerosList;
        ConjuntoList = conjuntoList;
    }

    public Conjunto(IEnumerable<Numero> numerosList)
    {
        NumerosList = numerosList;
    }

    public double Somar(){
        double montante = 0;

        if(NumerosList?.Count() > 0)
            foreach(Numero num in NumerosList)
                montante += num.Somar();
        
        if(ConjuntoList?.Count() > 0)
            foreach(Conjunto conj in ConjuntoList)
                montante += conj.Somar();

        return montante;
    }
}
