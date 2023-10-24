using Design_Patterns.Composite;

Conjunto conjunto = new(new List<Numero>(){new (10), new (20)},
                        new List<Conjunto>(){new (new List<Numero>(){new (10), new (20)}),
                        new (new List<Numero>(){new (10), new (20)})}      
                    );
System.Console.WriteLine(conjunto.Somar());
