using Design_Patterns.Decorator;

ICoffee coffee = new Coffee();

ICoffee baseDec = new CoffeeDecorator(coffee);

CoffeeMilk milkDec = new CoffeeMilk(baseDec);

CoffeeSugar sugarDec = new CoffeeSugar(milkDec);

System.Console.WriteLine(sugarDec.Describe());