using Design_Patterns.AbstractFactory;

Moto automovel = (Moto)AutomovelFactory.GetAutomovel(new MotoFactory(), "Casual");

System.Console.WriteLine(automovel.QuantidadeMotor); 


