using Design_Patterns.Factory;

var automovel = AutomovelFactory.GetAutomovel("Moto");

System.Console.WriteLine(automovel.NumeroRodas); 


