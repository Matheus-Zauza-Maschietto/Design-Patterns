using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton;

public class CarLazyInit
{
    private static CarLazyInit Instance;

    public int MyNumber {get; private set;}
    public string MyName {get; private set;}

    private CarLazyInit(){}

    public static CarLazyInit GetInstance(){
        if(Instance is null){
            Instance = new CarLazyInit();
        }
        return Instance;
    }

    public void InputValues(int myNumber, string myName){
        this.MyName = myName;
        this.MyNumber = myNumber;
    }
}
