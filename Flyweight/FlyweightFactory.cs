namespace Design_Patterns.Flyweight;

public class FlyweightFactory
{
    private List<Flyweight> Cache = new ();
    public FlyweightFactory()
    { }

    public Flyweight? GetFlyweight(string type){
        foreach(Flyweight flyweight in Cache)
            if(flyweight.Type == type)
                return flyweight;
        
        if(type == "PI"){
            Flyweight flyweight = new(3.14159265358979323846m, type);
            Cache.Add(flyweight);
            return flyweight;
        }
        else if(type == "AUREA"){
            Flyweight flyweight = new(1.61803398875m, type);
            Cache.Add(flyweight);
            return flyweight;
        }

        return null;
    } 

    public void ShowCache(){
        foreach(Flyweight flyweight in Cache)
        {
            System.Console.WriteLine(flyweight.Type);
            System.Console.WriteLine(flyweight.Constante);
        }
    }
}
