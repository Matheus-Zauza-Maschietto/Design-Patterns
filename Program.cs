using Design_Patterns.Decorator;

var decorator = new CoffeeDecorator(new Coffee());

var milk = new CoffeeMilk(decorator);

var sugar = new CoffeeSugar(milk);

System.Console.WriteLine(sugar.());
