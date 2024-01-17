using Design_Patterns.Iterator;


IterableCollection iterableCollection = new ConcreteCollection<string>(new (){"Olá", "Sou", "Uma", "Lista"}, new (){"Good", " Morning", "Im", "a", "Tree"});

Iterator iteratorList = iterableCollection.CreateListIterator();

System.Console.WriteLine(iteratorList.GetNext());
System.Console.WriteLine(iteratorList.GetNext());
System.Console.WriteLine(iteratorList.GetNext());
System.Console.WriteLine(iteratorList.GetNext());
System.Console.WriteLine(iteratorList.HasMore());

Iterator iteratorTree = iterableCollection.CreateTreeIterator();

System.Console.WriteLine(iteratorTree.GetNext());
System.Console.WriteLine(iteratorTree.GetNext());
System.Console.WriteLine(iteratorTree.GetNext());
System.Console.WriteLine(iteratorTree.GetNext());
System.Console.WriteLine(iteratorTree.GetNext());
System.Console.WriteLine(iteratorTree.HasMore());
