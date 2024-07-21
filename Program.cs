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


using Design_Patterns.Observer;

IPublisher publisher = new Publisher();
ISubscriber subscriber1 = new Subscriber();
ISubscriber subscriber2 = new Subscriber();
ISubscriber subscriber3 = new Subscriber();

publisher.Subscribe(subscriber1);
publisher.Subscribe(subscriber2);
publisher.Subscribe(subscriber3);

publisher.NotifySubscribers();

publisher.Unsubscribe(subscriber3);

publisher.NotifySubscribers();
