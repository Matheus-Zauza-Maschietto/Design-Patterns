using Design_Patterns.Builder;

Carro c1 = new Carro.CarroBuilder(10, 5, Marcas.TESLA)
                    .SetHasDirecaoHidraulica(true)
                    .SetHasVidroEletrico(false)
                    .Build();

System.Console.WriteLine(c1.Cavalos);
System.Console.WriteLine(c1.HasDirecaoHidraulica);
System.Console.WriteLine(c1.HasVidroEletrico);
System.Console.WriteLine(c1.Portas);
System.Console.WriteLine(c1.Marca); 