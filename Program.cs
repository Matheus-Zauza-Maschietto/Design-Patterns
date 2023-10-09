using Design_Patterns.Singleton;

CarLazyInit.GetInstance().InputValues(19, "matheus");

CarLazyInit singleton = CarLazyInit.GetInstance();
System.Console.WriteLine(singleton.MyName + " = " + singleton.MyNumber);

