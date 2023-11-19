using Design_Patterns.Flyweight;

FlyweightFactory factory = new();

GeometricCalculator g1 = new("PI*R^2", factory.GetFlyweight("PI"));
GeometricCalculator g2 = new("wdqd", factory.GetFlyweight("AUREA"));
GeometricCalculator g3 = new("PI*R^2", factory.GetFlyweight("PI"));
GeometricCalculator g4 = new("qwdqwd", factory.GetFlyweight("AUREA"));
GeometricCalculator g5 = new("223*R^2", factory.GetFlyweight("AUREA"));
factory.ShowCache();