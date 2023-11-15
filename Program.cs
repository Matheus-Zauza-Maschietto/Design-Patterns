using Design_Patterns.Proxy;

IComputador comp = new ComputadorProxy();

comp.Desligar();
comp.Ligar();
comp.AbrirNavegador();
comp.AbrirNavegador();
comp.FecharNavegador();
comp.Desligar();