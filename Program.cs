using Design_Patterns.Bridge;

Celular celular = new();
Aparelho aparelho = new (celular);

aparelho.IniciamentoRapido();
System.Console.WriteLine(celular.IsCelularAtInternet);
System.Console.WriteLine(celular.IsCelularOn);
System.Console.WriteLine(celular.IsCelularScreenOn);

aparelho.ColocarEmStandBy();
System.Console.WriteLine(celular.IsCelularAtInternet);
System.Console.WriteLine(celular.IsCelularOn);
System.Console.WriteLine(celular.IsCelularScreenOn);
