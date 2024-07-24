// using Design_Patterns.Iterator;


// IterableCollection iterableCollection = new ConcreteCollection<string>(new (){"Olá", "Sou", "Uma", "Lista"}, new (){"Good", " Morning", "Im", "a", "Tree"});

// Iterator iteratorList = iterableCollection.CreateListIterator();

// System.Console.WriteLine(iteratorList.GetNext());
// System.Console.WriteLine(iteratorList.GetNext());
// System.Console.WriteLine(iteratorList.GetNext());
// System.Console.WriteLine(iteratorList.GetNext());
// System.Console.WriteLine(iteratorList.HasMore());

// Iterator iteratorTree = iterableCollection.CreateTreeIterator();

// System.Console.WriteLine(iteratorTree.GetNext());
// System.Console.WriteLine(iteratorTree.GetNext());
// System.Console.WriteLine(iteratorTree.GetNext());
// System.Console.WriteLine(iteratorTree.GetNext());
// System.Console.WriteLine(iteratorTree.GetNext());
// System.Console.WriteLine(iteratorTree.HasMore());


// using Design_Patterns.Observer;

// IPublisher publisher = new Publisher();
// ISubscriber subscriber1 = new Subscriber();
// ISubscriber subscriber2 = new Subscriber();
// ISubscriber subscriber3 = new Subscriber();

// publisher.Subscribe(subscriber1);
// publisher.Subscribe(subscriber2);
// publisher.Subscribe(subscriber3);

// publisher.NotifySubscribers();

// publisher.Unsubscribe(subscriber3);

// publisher.NotifySubscribers();

// using Design_Patterns.Strategy;

// Context context = new Context();
// ConsoleStrategy consoleStrategy = new ConsoleStrategy();
// BuilderStrategy builderStrategy = new BuilderStrategy();
// context.SetStrategy(consoleStrategy);
// context.ExecuteStrategy("Teste strategy console");
// context.SetStrategy(builderStrategy);
// context.ExecuteStrategy("Teste strategy builder");

using System.Security;
using Design_Patterns.Visitor;

IVisitor visitor = new Visitor();

Car car = new Car("Fox");

Truck truck = new Truck("Tanker");

car.Accept(visitor);

truck.Accept(visitor);