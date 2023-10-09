using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton;

public sealed class CarEagerInit
{
    private static CarEagerInit Instance = new ();
    public int MyNumber { get; private set; }
    
    public string MyName { get; private set; }

    private CarEagerInit(){}
    
    public static CarEagerInit GetInstance(){
        return Instance;
    }

    public void InputValues(int myNumber, string myName){
        this.MyName = myName;
        this.MyNumber = myNumber;
    }
}
